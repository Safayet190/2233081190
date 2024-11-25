using System;

public class math{
    
    public int real {get; set;}
    public int fake {get; set;}
    
    public math(int r, int f){
        real = r;
        fake = f;
    }
    
    // operator overloading
    public static math operator + (math a, math b){
        return new math(a.real + b.real, a.fake + b.fake);
    }
    
    public void Show(){
        Console.WriteLine($"Sum is : {real} + {fake}i");
    }
    
}

public class H4WK{
    public static void Main(string[] args){
       
       math obj1 = new math(7, 9);
       math obj2 = new math(6, 10);
       
       math obj3 = obj1 + obj2;
       obj3.Show(); 
        
    }
}
