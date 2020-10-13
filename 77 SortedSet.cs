Link- https://onlinegdb.com/SkLEzviHv


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
      Console.WriteLine("Elements of mySet: ");
      foreach(var val in mySet)
      {
          Console.WriteLine(val);
      }
      
    }
}