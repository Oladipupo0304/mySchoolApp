
using System;
using Console_My_Jotter;



public class Program

  
    


{
    static void Main(string[] args)
    {
         


        Console.WriteLine("Enter student details:");
        Console.Write("Name: ");
        var name = Console.ReadLine()!;
        Console.Write("Class: ");
        var _class = Console.ReadLine()!;
        Console.Write("Gender: ");
        var gender = Console.ReadLine()!;
        Console.Write("Gmail: ");
        var gmail = Console.ReadLine()!;
        Console.Write("Date of Birth (dd/MM/yyyy): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine()!);

        // Create an object of the derived class
        PrimaryStudent student = new PrimaryStudent(name,_class, gender, dateOfBirth, gmail);

        // Display student details
        student.DisplayDetails();
    }
}
  








// // using System;

// // namespace Console_My_Jotter
// // {
// //    public class Program : Vehicle

// //   {
// //     static void Main(string[] args)
// //       {
// //         Car myCars = new Car();

// //           Console.WriteLine(myCars.model + "," + myCars.year + ",");
// //           Console.WriteLine(myCars.noOfCars);
// //           myCars.version();
// //       }

// //   }
// // }





// // namespace MyApplication
// // {
// //   class Animal : Pig // Base class (parent) 
// //   {
// //     public void animalSound()
// //     {
// //       Console.WriteLine("The animal makes a sound");
// //     }
// //   }

// //   class Pig // Derived class (child) 
// //   {
// //   public void pigSound()
// //     {
// //       Console.WriteLine("The pigs says wee wee");
// //     }
   
// //   }

// //   class Dog  : Animal  // Derived class (child) 
// //   {
// //     public void dogSound()
// //     {
// //       Console.WriteLine("The dog says: bow wow");
// //     }
// //   }

// // class Cat : Animal
// //   {
    
// //       public void catSound()
// //     {
// //      Console.WriteLine("the cats says: meaow");
        
// //     }
// //   }
// //   class Program
// //   {
// //     static void Main(string[] args)
// //     {
// //       Animal myAnimal = new Animal();  // Create a Animal object
// //       myAnimal.pigSound();
// //       Pig myPig = new Pig();  // Create a Pig object
// //       Dog myDog = new Dog();  // Create a Dog object
// //       Cat mycat = new Cat(); //  Create a Cat object 
      
// //       myPig.pigSound();   
// //       myDog.dogSound();
// //       myDog.animalSound();
// //       mycat.catSound();
// //       mycat.animalSound();
      
      
// //     }
// //   }
// // }







// ////////////////////////////////////////////////////////////////////////////////////////









// //  using System.Collections;
// //  using System.ComponentModel;

// // {
 
// //     Queue<int> data = new Queue<int>();
// //         data.Enqueue(3);
// //         data.Enqueue(5);
// //         data.Enqueue(20);
// //         data.Enqueue(47);
// //     foreach (var i in data)
// //     {
// //         Console.WriteLine();
// //     }
  
// // //   List<string> names = new List<string>();
// // //     names.Add("samad");
// // //     names.Add("tunde");
// // //     names.Add("saleeem");
// // //     names.Add("amirat");


// // //     foreach (var i in names)
// // //     {
// // //         Console.WriteLine($"my name is {i}");
// // //     }
// // }

// // Stack<string> name = new Stack<string>();
// //     name.Push("samad");
// //     name.Push("tunde");
// //     name.Push("saleeem");
// //     name.Push("amirat");
// //     name.Pop();

// //     foreach (var i in name)
// //     {
// //         Console.WriteLine( i );
// //     }

// //     Dictionary<int,string> dic = new Dictionary<int,string>();
// //     dic.Add(1, "samad");
// //     dic.Add(2,"tunde");
// //     dic.Add(3, "saleeem");
// //     dic.Add(4,"amirat");
// //     dic.Add(5,"lood");

// //     foreach (var i in dic)
// //     {
// //         Console.WriteLine($"my name: {i.Key}, {i.Value}");
// //     }
// //     //using non generic

// //     //ArrayList
    
// //    ArrayList myArrayList = new ArrayList();
// //    myArrayList.Add(1);
// //    myArrayList.Add("tunde");
// //    myArrayList.Add('w');

// //    foreach (var lol in myArrayList)
// //    {
// //     Console.WriteLine(lol);
// //    }
   

//    shape CallingShape = new shape(23 ,30)

  
// public struct Shape
// {

//        public int a;
//        public int b;

//        public shape(int a, int b)
//        {
//         a = a ;
//         b = B ;
//        }
// }
    
 

 


  

