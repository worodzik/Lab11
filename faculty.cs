using System;

class Faculty : Person{
  
  public string Id {get; set;}
  public string Title {get; set;}
  public DateTime DateOfEmployment{get;set;}
  public string Employer {get;set;}
  public double YearSalary{get;set;}
  public bool Tenured {get;set;}

  public Faculty() : base(){
     Title = "Instructor";
  }

  public Faculty (string first , string last) : base (first, last){
    Title = "Instructor";
  }

  public bool GrantTenured(){
    int numyear = DateTime.Today.Year - DateOfEmployment.Year;
    if (numyear > 5){
      Tenured = true;
      return Tenured;
    } 
    else{
      Tenured = false;
      return Tenured;
    }
  }

    public void Promote(){

      int experience = DateTime.Today.Year -  DateOfEmployment.Year;

      if ((Title.ToUpper() == "INSTRUCTOR") && (experience > 2)){
        Title = "Assistant Professor";
        Console.WriteLine("Faculty promoted to Assistant Professor rank");
      }
      else if ((Title.ToLower() == "assistant professor") && (experience > 5) ){
        Title = "Associate Professor";
          Console.WriteLine("Faculty promoted to Associate Professor rank");
      }
      else if ((Title.ToLower() == "associate professor") && (experience > 10)){
        Title = "Professor";
        Console.WriteLine("Faculty promoted to Professor rank");
      }
      else if (Title.ToLower() == "professor"){
        Console.WriteLine("No more promotion possible");
      }
      else{
        Console.WriteLine("something goes wrong!");
      }  

    }

    public override void Intro(){
      base.Intro();
      Console.WriteLine("I work as " + Title + "at " + Employer + "since " + DateOfEmployment.Year );
      
    }
   
  

}