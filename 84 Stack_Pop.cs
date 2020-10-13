Link- https://onlinegdb.com/SkRRSmJUv

using System;
using System.Collections;
class GFG 
{
    static public void Main(String[] args)
    {
       Stack my_stack = new Stack();
       my_stack.Push("Hi");
       my_stack.Push("I am");
       my_stack.Push("Aayushi");
       my_stack.Push("Rathi");
       my_stack.Push(null);
       my_stack.Push(1);
       my_stack.Push(180.45);
       
       foreach(var ele in my_stack)
       {
           Console.WriteLine(ele);
       }
        
       my_stack.Pop();
       Console.WriteLine();
       
       foreach(var ele in my_stack)
       {
           Console.WriteLine(ele);
       } 
       
       my_stack.Clear();
       Console.WriteLine();
       Console.WriteLine("Total number of elemets in my_stack: "+ my_stack.Count);
    }
}

