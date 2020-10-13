Link- https://onlinegdb.com/S1pYZGqHw


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
     myhash1.Add("A");
     myhash1.Add("Z");
     myhash1.Add("F");
     myhash1.Add("D");
     myhash1.Add("E");
     
      
     myhash1.UnionWith(myhash2); 
        foreach(var ele in myhash1) 
        { 
            Console.WriteLine(ele); 
        } 
    }
}