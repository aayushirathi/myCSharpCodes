Link- https://onlinegdb.com/HkMd_JcrD


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class GFG 
{
    public static void Main()
    {
        Collection<int> myColl = new Collection<int>();
        myColl.Add(2);
        myColl.Add(5);
        myColl.Add(3);
        
        foreach(int n in myColl)
        {
            Console.WriteLine(n);
        }
    }
} 
 