namespace MySchoolApp
{
    public abstract class User 

   {
    public string? Name { get; set; }
    public string? Age {get; set;}
    public string? Sex {get; set;}
    public string? dateOfBirth {get; set;}

    public abstract void DisplayInformation();
   }

}
