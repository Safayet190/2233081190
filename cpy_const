using System;
public class Business{
   public string name;
   private double cash;
   
   public double Cash{
       get { return cash; }
       set { cash = value; }
   }
   
   // normal constructor
   public Business(string Name, double Balance){
       name = Name;
       Cash = Balance;
   }
   
   // copy constructor
   public Business(Business new_ac){
       name = new_ac.name;
       Cash = new_ac.Cash;
   }
   
   public void Show(){
       Console.WriteLine($"Name : {name}\nBalance : {Cash}\n");
   }
    
}

public class Shop{
    public static void Main(string[] args){
        
        Business old_ac  = new Business("Charlie", 1500);
        
        Business new_ac = old_ac; // shallow copy
        new_ac.Cash = 1250;
         
        new_ac.Show(); // Balance : 1250
        old_ac.Show(); // Balance : 1250 (chage from 1500 to 1250)
        
        // now, old_ac balance is 1250 
        // usage of copy constructor
        
        Business new_ac_cpy = new Business(old_ac); // deep copy
        new_ac_cpy.Cash = 9999;
        
        new_ac_cpy.Show(); // Balance : 9999
        old_ac.Show();     // Balance : 1250 (doesn't chage to 9999)
                
    }
}
