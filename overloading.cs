using System;
public class Self{

  // method overloading  
  public int Add(int a, int b){
     return a + b;
   }

   public double Add(double a, double b){
    return a + b;
   }

   public int Add(int a, int b, int c){
    return a + b + c;
   }

  public string name {get; set;}
  public int age {get; set;}
  public int id {get; set;}
  public string number {get; set;}
  
  // constructor overloading
  public Self(){
    name = "Default";
    age = 0;
    id = 0;
    number = "01700-000000";
  }

  public Self(string Name, int Age, int Id, string Number){
    name = Name;
    age = Age;
    id = Id;
    number = Number;
  }


  public void Show(){

    Console.WriteLine("--Student Info--");
    Console.WriteLine("Name : " + name);
    Console.WriteLine("Age : " + age);
    Console.WriteLine("ID : " + id);
    Console.WriteLine("Cell : " + number);
    Console.WriteLine();

  } 

}

public class Proj{
    public static void Main(string[] args){
    
    // default constructor
    Self person = new Self();
    person.Show();
    
    // constructor overloading 
    Self person1 = new Self("Huzaifa", 21, 1500, "01799-999999");
    person1.Show();  

    // method overloading
    Self add = new Self();
    Console.WriteLine(add.Add(10, 15));
    Console.WriteLine(add.Add(7, 8, 9));
    Console.WriteLine(add.Add(95.3, 12.94));
    Console.WriteLine();

   }  

}
