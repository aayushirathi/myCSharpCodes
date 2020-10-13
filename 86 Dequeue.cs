Link- https://onlinegdb.com/rkbxxS1Iw

using System;
using System.Collections;
class GFG 
{
    static public void Main(String[] args)
    {
    Queue myQueue = new Queue();

    myQueue.Enqueue("Hello");
    myQueue.Enqueue(" I");
    myQueue.Enqueue(" am");
    myQueue.Enqueue(" Aayushi");
    myQueue.Enqueue(" Rathi.");
    Console.WriteLine("Total number of elements in myQueue: "+ myQueue.Count);
    myQueue.Dequeue();
    Console.WriteLine();
    Console.WriteLine("Total number of elements now: "+myQueue.Count);
    myQueue.Clear();
    Console.WriteLine("Total number of elements now: "+myQueue.Count);
    }
}