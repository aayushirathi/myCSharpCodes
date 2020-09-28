Link- https://onlinegdb.com/HJF37J9Sv


using System;
using System.Collections.Generic;
class Geeks 
{
  public static void Main(String[] args)
  {
    List<int> mylist = new List<int>();
    for(int i=5; i<10; i++)
    {
      mylist.Add(i*4);
    }
    foreach(int items in mylist)
    {
      Console.WriteLine(items);
    }
  }
}