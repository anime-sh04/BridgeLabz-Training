using System;

class Course{
    public string CourseName;
    public int Duration;

    public Course(string courseName,int duration){
        CourseName = courseName;
        Duration = duration;
    }

    public void ShowCourse(){
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " hours");
    }
}

class OnlineCourse : Course{
    public string Platform;
    public bool IsRecorded;

    public OnlineCourse(string courseName,int duration,string platform,bool isRecorded)
        : base(courseName,duration){
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public void ShowOnlineCourse(){
        ShowCourse();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + IsRecorded);
    }
}

class PaidOnlineCourse :OnlineCourse{
    public double Fee;
    public double Discount;

    public PaidOnlineCourse(string courseName,int duration,string platform,bool isRecorded,double fee,double discount)
        :base(courseName,duration,platform,isRecorded){
        Fee =fee;
        Discount = discount;
    }

    public void ShowPaidCourse(){
        ShowOnlineCourse();
        Console.WriteLine("Fee:" +Fee);
        Console.WriteLine("Discount: " +Discount + "%");
    }
}

class EducationalCourseHierarchy{
    static void Main(string[] args){
        PaidOnlineCourse course = new PaidOnlineCourse("C#",40,"Udemy",true,5000,20);

        course.ShowPaidCourse();
    }
}
