using System;
using System.Text;
class GFG {
  public static void Main()
  {
    StringBuilder s = new StringBuilder("Your total amount is ");
    s.AppendFormat("{0:C} ", 50);
    Console.WriteLine(s);
  }
}