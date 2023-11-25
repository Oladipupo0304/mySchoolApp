
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Console_My_Jotter
{
    public abstract class Student
    {
    public string Name { get; set; }
    public string Class { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string gmail {get; set;}
    // public string _ClassTeaching {get; set; }

    // Constructor
    public Student(string name, string _class, string gender, DateTime dateOfBirth,string gmail )
    {
        Name = name;
        Class = _class;
        Gender = gender;
        this.gmail = gmail;
        DateOfBirth = dateOfBirth;
        
    }

    // Abstract method to display details
    public abstract void DisplayDetails();
       
        
    }
}