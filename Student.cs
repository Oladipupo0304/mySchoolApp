namespace MySchoolApp
{
    public class Student : User

    {
    public string? Grade { get; set; }


    public override void DisplayInformation()
        {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Sex: {Sex}");
        Console.WriteLine($"dateOFBirth (dd-mm-yyyy: {dateOfBirth}");
        //Console.WriteLine($"Date of Birth:{DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Grade: {Grade}");
        }
    
    }
}