CREATE DATABASE HealthCareManagement;

USE HealthCareManagement;

-- PATIENT DETAILS

CREATE TABLE PatientDetails(
	PatientId INT IDENTITY(1,1) PRIMARY KEY,
	PatientName VARCHAR(100),
	PatientDOB DATE,
	PatientContact BIGINT,
	PatientAddress VARCHAR(500),
	PatientBloodGroup VARCHAR(3)
);


SELECT * from PatientDetails;

CREATE TABLE Speciality(
	SpecialityId INT IDENTITY(1,1) PRIMARY KEY,
	SpecialityName VARCHAR(50)
);

INSERT INTO Speciality(SpecialityName)
VALUES ('Cardiology'),('Neurology'),('Orthopedics');


             
CREATE TABLE DoctorDetails(
	DoctorId INT IDENTITY(1,1) PRIMARY KEY,
	DoctorName VARCHAR(100),
	SpecialityId INT NOT NULL,
	DoctorContact BIGINT,
	DoctorFee INT,
	DoctorIsActive BIT DEFAULT 1,

	CONSTRAINT FK_Doctor_Speciality
		FOREIGN KEY (SpecialityId)
		REFERENCES Speciality(SpecialityId)
);

SELECT * FROM DoctorDetails;

CREATE PROCEDURE UpdateDoctorSpeciality
    @DoctorId INT,
    @SpecialityId INT
AS
BEGIN
    BEGIN TRANSACTION;

    IF NOT EXISTS (
        SELECT 1 FROM DoctorDetails
        WHERE DoctorId = @DoctorId AND DoctorIsActive = 1
    )
    BEGIN
        ROLLBACK;
        THROW 50001, 'Doctor not found or inactive.', 1;
    END

    IF NOT EXISTS (
        SELECT 1 FROM Speciality WHERE SpecialityId = @SpecialityId
    )
    BEGIN
        ROLLBACK;
        THROW 50002, 'Invalid Speciality ID.', 1;
    END

    UPDATE DoctorDetails
    SET SpecialityId = @SpecialityId
    WHERE DoctorId = @DoctorId;

    COMMIT;
END;


--EXEC UpdateDoctorSpeciality @DoctorId = 6,@SpecialityId = 3;


CREATE TABLE AppointmentDetails(
	ApptId INT IDENTITY(1,1) PRIMARY KEY,
	ApptDate DATE,
	ApptTime TIME,
	Status VARCHAR(20) DEFAULT 'SCHEDULED',
	PatientId INT NOT NULL,
	DoctorId INT NOT NULL
);

SELECT * from AppointmentDetails;

CREATE PROCEDURE BookAppointment
	@PatientId INT,
	@DoctorId INT,
	@ApptDate DATE,
	@ApptTime TIME

AS
BEGIN
	BEGIN TRANSACTION;
	IF NOT EXISTS(SELECT 1 FROM PatientDetails WHERE PatientId = @PatientId)
	BEGIN
		ROLLBACK;
		THROW 50001, 'Invalid Patient',1;
	END

	IF NOT EXISTS(SELECT 1 FROM DoctorDetails 
	WHERE DoctorId = @DoctorId
	AND DoctorIsActive = 1)
	BEGIN
		ROLLBACK;
		THROW 50002, 'Invalid Or inactive Doctor', 1;
	END

	IF EXISTS(SELECT 1 FROM AppointmentDetails WHERE 
		DoctorId = @DoctorId 
		AND ApptDate = @ApptDate 
		AND ApptTime = @ApptTime 
		AND Status = 'SCHEDULED')
	BEGIN
		ROLLBACK;
		THROW 50003, 'slot already Booked',1;
	END

    INSERT INTO AppointmentDetails
    (PatientId, DoctorId, ApptDate, ApptTime, Status)
    VALUES
    (@PatientId, @DoctorId, @ApptDate, @ApptTime, 'SCHEDULED');

    COMMIT;
END;

SELECT * from AppointmentDetails;
EXEC BookAppointment @PatientId = 1,@DoctorId = 6,@ApptDate = '2026-11-28',@ApptTime ='23:19'; 


CREATE TABLE Appointment_Audit (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    ApptId INT NOT NULL,
    Action VARCHAR(20) NOT NULL, 
    OldStatus VARCHAR(20),
    NewStatus VARCHAR(20),
    ActionBy VARCHAR(50),           
    ActionDate DATETIME DEFAULT GETDATE()
);

CREATE PROCEDURE CancelAppointment
    @ApptId INT,
    @CancelledBy VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;
    IF NOT EXISTS (
        SELECT 1 
        FROM AppointmentDetails
        WHERE ApptId = @ApptId
          AND Status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        THROW 50010, 'Appointment not found or already cancelled', 1;
    END

    -- 2. Insert audit log
    INSERT INTO Appointment_Audit
    (ApptId, Action, OldStatus, NewStatus, ActionBy)
    VALUES
    (@ApptId, 'CANCELLED', 'SCHEDULED', 'CANCELLED', @CancelledBy);

    -- 3. Update appointment status
    UPDATE AppointmentDetails
    SET Status = 'CANCELLED'
    WHERE ApptId = @ApptId;

    COMMIT;
END;
GO


CREATE PROCEDURE DeactivateDoctor
    @DoctorId INT
AS
BEGIN
    BEGIN TRANSACTION;

    IF EXISTS (
        SELECT 1
        FROM AppointmentDetails
        WHERE DoctorId = @DoctorId
          AND ApptDate > CAST(GETDATE() AS DATE)
          AND Status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        THROW 50030, 'Doctor has future appointments and cannot be deactivated', 1;
    END

    UPDATE DoctorDetails
    SET DoctorIsActive = 0
    WHERE DoctorId = @DoctorId;

    COMMIT;
END;
GO


CREATE PROCEDURE RescheduleAppointment
    @ApptId INT,
    @NewDoctorId INT,
    @NewApptDate DATE,
    @NewApptTime TIME
AS
BEGIN
    BEGIN TRANSACTION;
    IF NOT EXISTS (
        SELECT 1
        FROM AppointmentDetails
        WHERE ApptId = @ApptId
          AND Status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        THROW 50050, 'Appointment not found or not reschedulable', 1;
    END

    IF EXISTS (
        SELECT 1
        FROM AppointmentDetails
        WHERE DoctorId = @NewDoctorId
          AND ApptDate = @NewApptDate
          AND ApptTime = @NewApptTime
          AND Status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        THROW 50051, 'New slot already booked', 1;
    END

    UPDATE AppointmentDetails
    SET DoctorId = @NewDoctorId,
        ApptDate = @NewApptDate,
        ApptTime = @NewApptTime
    WHERE ApptId = @ApptId;

    COMMIT;
END;
GO


--DROP PROCEDURE RescheduleAppointment;


CREATE TABLE Visits (
    VisitId INT IDENTITY(1,1) PRIMARY KEY,
    ApptId INT NOT NULL,
    Diagnosis VARCHAR(255),
    Prescription VARCHAR(255),
    Notes VARCHAR(500),
    VisitDate DATETIME DEFAULT GETDATE()
);


CREATE PROCEDURE RecordPatientVisit
    @ApptId INT,
    @Diagnosis VARCHAR(255),
    @Prescription VARCHAR(255),
    @Notes VARCHAR(500)
AS
BEGIN
    BEGIN TRANSACTION;

    -- 1. Check appointment exists and is scheduled
    IF NOT EXISTS (
        SELECT 1
        FROM AppointmentDetails
        WHERE ApptId = @ApptId
          AND Status = 'SCHEDULED'
    )
    BEGIN
        ROLLBACK;
        THROW 50060, 'Invalid appointment or already completed', 1;
    END

    INSERT INTO Visits
    (ApptId, Diagnosis, Prescription, Notes)
    VALUES
    (@ApptId, @Diagnosis, @Prescription, @Notes);

    -- 2. Update appointment status
    UPDATE AppointmentDetails
    SET Status = 'COMPLETED'
    WHERE ApptId = @ApptId;

    COMMIT;
END;
GO


CREATE TABLE Prescriptions (
    PrescriptionId INT IDENTITY(1,1) PRIMARY KEY,
    VisitId INT NOT NULL,
    MedicineName VARCHAR(100),
    Dosage VARCHAR(50),
    Duration VARCHAR(50)
);


CREATE TABLE Bills (
    BillId INT IDENTITY(1,1) PRIMARY KEY,
    VisitId INT NOT NULL,
    TotalAmount DECIMAL(10,2),
    PaymentStatus VARCHAR(20) DEFAULT 'UNPAID',
    BillDate DATETIME DEFAULT GETDATE()
);

ALTER TABLE Bills
ADD PaymentDate DATETIME,
    PaymentMode VARCHAR(50);


CREATE PROCEDURE GenerateBill
    @VisitId INT
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @DoctorFee DECIMAL(10,2);
    DECLARE @AdditionalCharges DECIMAL(10,2);
    DECLARE @Total DECIMAL(10,2);

    -- 1️ consultation fee
    SELECT @DoctorFee = d.DoctorFee
    FROM Visits v
    INNER JOIN AppointmentDetails a ON v.ApptId = a.ApptId
    INNER JOIN DoctorDetails d ON a.DoctorId = d.DoctorId
    WHERE v.VisitId = @VisitId;

    -- 2️ Get additional charges using SUM()
    SELECT @AdditionalCharges = ISNULL(SUM(ChargeAmount), 0)
    FROM AdditionalCharges
    WHERE VisitId = @VisitId;

    -- 3️ Calculate total
    SET @Total = @DoctorFee + @AdditionalCharges;

    -- 4️ Insert bill
    INSERT INTO Bills
    (VisitId, TotalAmount)
    VALUES
    (@VisitId, @Total);

    COMMIT;
END;
GO


CREATE TABLE PaymentTransactions (
    TransactionId INT IDENTITY(1,1) PRIMARY KEY,
    BillId INT NOT NULL,
    Amount DECIMAL(10,2),
    PaymentMode VARCHAR(50),
    TransactionDate DATETIME DEFAULT GETDATE()
);


CREATE PROCEDURE RecordPayment
    @BillId INT,
    @PaymentMode VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @Amount DECIMAL(10,2);

    -- 1️ Check bill exists and is unpaid
    IF NOT EXISTS (
        SELECT 1 FROM Bills
        WHERE BillId = @BillId
          AND PaymentStatus = 'UNPAID'
    )
    BEGIN
        ROLLBACK;
        THROW 50070, 'Bill not found or already paid', 1;
    END

    -- 2️ Get bill amount
    SELECT @Amount = TotalAmount
    FROM Bills
    WHERE BillId = @BillId;

    -- 3️ Update Bills table
    UPDATE Bills
    SET PaymentStatus = 'PAID',
        PaymentDate = GETDATE(),
        PaymentMode = @PaymentMode
    WHERE BillId = @BillId;

    -- 4️ Insert into PaymentTransactions
    INSERT INTO PaymentTransactions
    (BillId, Amount, PaymentMode)
    VALUES
    (@BillId, @Amount, @PaymentMode);

    COMMIT;
END;
GO


CREATE TABLE Audit_Log (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    TableName VARCHAR(100),
    OperationType VARCHAR(20),   -- INSERT / UPDATE / DELETE
    RecordId INT,
    ChangedBy VARCHAR(100),
    ChangeDate DATETIME DEFAULT GETDATE()
);


CREATE TRIGGER trg_Audit_Bills
ON Bills
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- INSERT
    INSERT INTO Audit_Log (TableName, OperationType, RecordId, ChangedBy)
    SELECT 'Bills', 'INSERT', BillId, SYSTEM_USER
    FROM inserted;

    -- DELETE
    INSERT INTO Audit_Log (TableName, OperationType, RecordId, ChangedBy)
    SELECT 'Bills', 'DELETE', BillId, SYSTEM_USER
    FROM deleted;

    -- UPDATE
    INSERT INTO Audit_Log (TableName, OperationType, RecordId, ChangedBy)
    SELECT 'Bills', 'UPDATE', BillId, SYSTEM_USER
    FROM inserted
    WHERE EXISTS (SELECT * FROM deleted);
END;






SELECT department_id, AVG(salary) AS average_salary
FROM employees
GROUP BY department_id;