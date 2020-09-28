using System;
using System.Text;
class GFG {
  public static void Main()
  { //20 is capacity
    StringBuilder s = new StringBuilder("Hello", 20);
    s.Append("Aayushi");
    s.AppendLine("Rathi.");
    //Line is appended
    s.Append("GeeksForGeeks");
    Console.WriteLine(s);
  }
}