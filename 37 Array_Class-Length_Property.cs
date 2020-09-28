using System;
namespace geeksforgeeks {
  class GFG {
    public static void Main() {
      string[] store;
      store = new string[] {"aaa,", "bbb,","ccc,", "ddd,", "eee."};
      Console.WriteLine("Length of store: "+ store.Length);
      Console.WriteLine("Different types of alphabets: ");
      Console.WriteLine();
      foreach(string alphabet in store)
      Console.Write(alphabet+" ");
    }
  }
}