namespace MySchoolApp
{
    
    public class TeacherInfo : User
    {
        public string? ClassTeaching {get; set;}
        public string? Subject {get; set;}
        public string?  Gmail {get; set;}

        public override void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"ClassTeaching: {ClassTeaching}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Date of Birth: {dateOfBirth}");
            // Console.WriteLine($"Date of Birth:{dateOfBirth.ToShortDateString()}");
            Console.WriteLine($"gmail: {Gmail}");
        }
    }
}