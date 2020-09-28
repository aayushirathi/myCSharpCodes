Link- https://onlinegdb.com/r17n8ycSv

using System;
using System.Collections;
class GFG 
{
  public static void Main()
  {
    Queue myQueue = new Queue();

    myQueue.Enqueue("Hello");
    myQueue.Enqueue(" I");
    myQueue.Enqueue(" am");
    myQueue.Enqueue(" Aayushi");
    myQueue.Enqueue(" Rathi.");
  
  Console.WriteLine("No. of elements in queue: "+ myQueue.Count);
  Console.WriteLine("Beginning item of queue is: "+myQueue.Peek());
  Console.WriteLine("Queue is: ");
  foreach(Object obj in myQueue)
  {
    Console.Write(obj);
  }
  }
}