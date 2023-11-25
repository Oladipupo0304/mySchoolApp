namespace Console_My_Jotter
{
    
    public class TeacherInfo : Student
    {

        public TeacherInfo(string name, string _class,string sex,DateTime dateOfBirth,string gmail)
        : base( name, _class,sex,dateOfBirth,gmail)

        {
        }

         //i am  Override the abstract method 
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {Class}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"gmail: {gmail}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
    }
    }
}