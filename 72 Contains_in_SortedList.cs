Link- https://onlinegdb.com/SJoMmZ5Hw


using System;
using System.Collections;
class GFG 
{
    static public void Main(String[] args)
    {
        SortedList mylist = new SortedList();
        mylist.Add(1.1, " I");
        mylist.Add(2.1, " am");
        mylist.Add(3.1, "Aayushi");
        mylist.Add(4.1," Rathi");
        
        if(mylist.Contains(3.1)==true)
        {
            Console.WriteLine("This is a key.");
        }
        else
        {
            Console.WriteLine("This is not a key.");
        }
        
        if(mylist.ContainsKey(2.1)==true)
        {
            Console.WriteLine("Key is found.");
        }
        else
        {
            Console.WriteLine("Key is not found.");
        }
        
        if(mylist.ContainsValue("Aayushi")==true)
        {
            Console.WriteLine("Key is found.");
        }
        else
        {
            Console.WriteLine("Key is not found.");
        }
        
    }
}