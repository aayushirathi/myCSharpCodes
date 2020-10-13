Link- https://onlinegdb.com/Sy6BtWcrD


using System;
using System.Collections.Generic;
class GFG 
{
    static public void Main(String[] args)
    {
     HashSet<string> myhash1 = new HashSet<string>();
     myhash1.Add("A");
     myhash1.Add("B");
     myhash1.Add("C");
     myhash1.Add("D");
     myhash1.Add("E");
     Console.WriteLine("Elements of myhash1: ");
     
     foreach(var val in myhash1)     
     {
         Console.WriteLine(val);
     }
     
      HashSet<int> myhash2 = new HashSet<int>();
      myhash2.Add(1);
      myhash2.Add(2);
      Console.WriteLine("Elements of myhash2: ");
      
      foreach(var value in myhash2)
      {
          Console.WriteLine(value);
      }
    }
}