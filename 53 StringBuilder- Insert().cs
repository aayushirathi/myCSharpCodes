using System;
using System.Text;
class GFG {
  public static void Main()
  {
    StringBuilder s = new StringBuilder("HELLO ", 20);

    // "GEEKS" insert after 6th index 
    s.Insert(6, "GEEKS");
    Console.WriteLine(s);
  }
}