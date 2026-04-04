using System;

namespace LoanBuddy
{
    class Applicant
    {
        private string name;
        private int creditScore;
        private double income;
        private double loanAmount;

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.income = income;
            this.loanAmount = loanAmount;
        }

        public string Name { get { return name; } }
        public int CreditScore { get { return creditScore; } }
        public double Income {get { return income; } }
        public double LoanAmount { get { return loanAmount; } }
    }

    interface IApprovable
    {
        bool ApproveLoan(Applicant applicant);
        double CalculateEMI();
    }
    abstract class LoanApplication : IApprovable
    {
        protected string loanType;
        protected int term;
        protected double interestRate;
        protected double principal;

        private bool approved;

        protected LoanApplication(double principal, int term, double interestRate)
        {
            this.principal = principal;
            this.term = term;
            this.interestRate = interestRate;
        }

        protected void SetApproval(bool status)
        {
            approved = status;
        }

        public bool IsApproved(){ return approved; } 

        protected double BaseEMI()
        {
            double r = interestRate / 12 / 100;
            int n = term;

            return principal * r * Math.Pow(1 + r, n) /(Math.Pow(1 + r, n) - 1);
        }

        public abstract bool ApproveLoan(Applicant applicant);
        public abstract double CalculateEMI();
    }

    class HomeLoan : LoanApplication
    {
        public HomeLoan(double principal, int term)
            : base(principal, term, 7.5)
        {
            loanType = "Home Loan";
        }

        public override bool ApproveLoan(Applicant applicant)
        {
            bool status = applicant.CreditScore >= 700 && applicant.Income >= 30000;
            SetApproval(status);
            return status;
        }

        public override double CalculateEMI()
        {
            return BaseEMI();
        }
    }
    class AutoLoan : LoanApplication
    {
        public AutoLoan(double principal, int term)
            : base(principal, term, 9.0)
        {
            loanType = "Auto Loan";
        }

        public override bool ApproveLoan(Applicant applicant)
        {
            bool status = applicant.CreditScore >= 650 &&
                          applicant.Income >= 20000;
            SetApproval(status);
            return status;
        }

        public override double CalculateEMI()
        {
            return BaseEMI() * 1.02;
        }
    }
    class LoanBuddy
    {
        static void Main()
        {
            Applicant user = new Applicant("Animesh", 720, 45000, 500000);

            LoanApplication loan = new HomeLoan(user.LoanAmount, 120);

            if (loan.ApproveLoan(user))
            {
                Console.WriteLine("Loan Approved!");
                Console.WriteLine("Monthly EMI: " + Math.Round(loan.CalculateEMI(), 2));
            }
            else
            {
                Console.WriteLine("Loan Rejected!");
            }
        }
    }
}
