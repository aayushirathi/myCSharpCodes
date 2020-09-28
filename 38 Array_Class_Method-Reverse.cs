using System;
namespace geeksforgeeks {
  class GFG {
    public static void Main() {
      string[] topic;
      topic = new string[] {"Array, ", "Stack, ", "Queue ", "Exception"};
      Console.WriteLine("Topics of C# before reversal: ");
      Console.WriteLine();
      foreach(string a in topic){
      Console.WriteLine(a+" ");
      }
      Console.WriteLine();
      Array.Reverse(topic);
      Console.WriteLine("Topics of C# after reversal: ");
      foreach(string b in topic)
      Console.WriteLine(b+" ");
      
    }
  }
}