Link- https://onlinegdb.com/BJDqXM9BP


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
     
     HashSet<string> myhash2 = new HashSet<string>();
     myhash2.Add("A");
     myhash2.Add("Z");
     myhash2.Add("F");
     myhash2.Add("D");
     myhash2.Add("E");
     
      
     myhash1.ExceptWith(myhash2); 
        foreach(var ele in myhash1) 
        { 
            Console.WriteLine(ele); 
        } 
    }
}

