Link- https://onlinegdb.com/rJgySS1Uw

using System;
using System.Collections.Generic;
class GFG 
{
    static public void Main(String[] args)
    {
     LinkedList<String> my_list = new LinkedList<String>();
     my_list.AddLast("Aayushi");
     my_list.AddLast("ABC");
     my_list.AddLast("BCD");
     my_list.AddLast("CDE");
     my_list.AddLast("DEF");
     
     foreach(string str in my_list)
     {
        Console.WriteLine(str);
     }
     
    }
}