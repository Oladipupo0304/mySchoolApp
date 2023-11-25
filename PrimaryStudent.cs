using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_My_Jotter
{
   public class PrimaryStudent : Student
     {
       public PrimaryStudent(string name, string _class, string gender, DateTime dateOfBirth,string gmail)
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
