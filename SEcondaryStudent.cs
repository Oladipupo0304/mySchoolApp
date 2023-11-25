namespace Console_My_Jotter
{
    public class SEcondaryStudent : Student
    {
        public  SEcondaryStudent(string name, string _class, string gender, DateTime dateOfBirth,string gmail )
        : base(name, _class, gender, dateOfBirth,gmail)

       {
       }

 //i am  Override the abstract method 
    public override void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {Class}");
        Console.WriteLine($"Gender: {Gender}");
         Console.WriteLine($"Gmail: {gmail}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
    }

    }
    
}