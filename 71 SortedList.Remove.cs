Link- https://onlinegdb.com/HJMEtWx9rw

using System;
using System.Collections;
class GFG
{
    static public void Main(String[] args)
    {
        SortedList slist1 = new SortedList(); 
        slist1.Add(1.45, " This");
        slist1.Add(2.0, " is");
        slist1.Add(2.1, " Aayushi");
        slist1.Add(1.3, " Rathi.");
        
        foreach(DictionaryEntry pair in slist1)
        {
            Console.Write(pair.Value);
        }
        Console.WriteLine();
        slist1.Remove(1.3);
        foreach(DictionaryEntry pair in slist1)
        {
            Console.Write(pair.Value);
        }
        Console.WriteLine();
        slist1.RemoveAt(2);
        foreach(DictionaryEntry pair in slist1)
        {
            Console.Write(pair.Value);
        }
        Console.WriteLine();
        slist1.Clear();
        Console.WriteLine(" Total no. of elements in slist1: "+ slist1.Count);
        
        
    }
}