Link- https://onlinegdb.com/rJ2yNDjHv


using System;
using System.Collections.Generic;
class GFG
{
    static public void Main()
    {
      SortedSet<int> mySet = new SortedSet<int>();
      mySet.Add(1001);
      mySet.Add(101);
      mySet.Add(1);
      mySet.Add(10001);
      mySet.Add(100);
      Console.WriteLine("Elements of mySet: ");
      
      foreach(var val in mySet)
      {
          Console.Write(val+" ");
      }
      Console.WriteLine();
      
      mySet.Remove(1001);
      Console.WriteLine("After removing: ");
      foreach(var val in mySet)
      {
          Console.Write(val+" ");
      }
      Console.WriteLine();
      
      mySet.Clear();
      Console.WriteLine("Total no. of elements in mySet: "+ mySet.Count);
      
      
    }
}