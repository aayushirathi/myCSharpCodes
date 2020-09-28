using System;
using System.Collections;
class GFG {
  public static void Main() {
    ArrayList myList = new ArrayList();
    myList.Add(1);
    myList.Add(2);
    myList.Add(3);
    myList.Add(4);
    myList.Add(5);
    Console.WriteLine("Number of elements: "+myList.Count);
    Console.WriteLine("Current capacity: "+myList.Capacity);
  }
}