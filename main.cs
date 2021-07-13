using System;
using System.Linq;

class MainClass 
{
  static double hours = 0.00;  

  public static double CalculateCharges()
  {
    double cost = 0.00;
    if(hours <= 3)
    {
      cost = 2.00;
    }

    else if(hours > 3 && hours <=19)
    {
      cost = 2.0 + .5 * (hours -3);
    }
     
    else
    {
      cost = 10;            
    }

    return cost;    
  }


  public static void Main (string[] args) 
  {    
    string customer = "";    
    
    while(customer != "n")
    {
      Console.WriteLine("How many hours was this customer parked?");      
      hours = Convert.ToDouble(Console.ReadLine()); 

      double x = CalculateCharges();
      Console.WriteLine("This customers total is $" + x);
    
      if(customer == "n")
      {
        break;
      }

      Console.WriteLine("Are there any more customers, y or n?");      
      customer = Console.ReadLine();
    }
    Console.WriteLine("this is the end!");
  }  
}