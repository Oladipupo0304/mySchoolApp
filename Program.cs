
using MySchoolApp;

class SchoolApp
{
    private static string? grade;
    private static string? name;
    private static int age;

    static void Main(string[] args)
    {
Console.WriteLine("Welcome to the School App!");

        // Collect student information
        Console.WriteLine("\nEnter Student Information:");
        Student student = CollectStudentInformation();

        // Collect teacher information
        Console.WriteLine("\nEnter Teacher Information:");
        TeacherInfo teacher = CollectTeacherInformation();

        // Display student and teacher information
        Console.WriteLine("\nStudent Information:");
        student.DisplayInformation();

        Console.WriteLine("\nTeacher Information:");
        teacher.DisplayInformation();

        Console.ReadLine();
    }

    private static Student CollectStudentInformation()
    {
        Console.Write("Enter Student Name: ");
        string Name = Console.ReadLine()!;

         Console.Write("Enter Student Sex: ");
        string Sex = Console.ReadLine()!;

         Console.Write("Enter DateOfBirth in this Formart [dd-mm-yyyy]: ");
        string dateOfBirth = Console.ReadLine()!;

        Console.Write("Enter Student Age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Student Grade: ");
        string Grade = Console.ReadLine()!;

        Student student = new Student()
        {
            Name = name,
            // Age = age,
            Sex = Sex,
            dateOfBirth = dateOfBirth,
            Grade = grade
        };

        return student;
    }

    static TeacherInfo CollectTeacherInformation()
    {
        Console.Write("Enter Teacher's Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Teacher's Age: ");
        int age = int.Parse(Console.ReadLine()!);

         Console.Write("Enter Teacher's Sex: ");
        string Sex = Console.ReadLine()!;

         Console.Write("Enter Teacher's class ");
        string ClassTeaching = Console.ReadLine()!;

        Console.Write("Enter The Subject Teaching: ");
        string subject = Console.ReadLine()!;

         Console.Write("Enter DateOfBirth in this Formart [dd-mm-yyyy]: ");
        string dateOFBirth= Console.ReadLine()!;

        TeacherInfo teacher = new TeacherInfo()
        {
            Name = name,
            // Age = age,
            Sex = Sex,
            ClassTeaching = ClassTeaching,
            Subject = subject,
            dateOfBirth = dateOFBirth,
        };

        return teacher;
    }
}






    
















  

