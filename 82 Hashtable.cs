Link- https://onlinegdb.com/ByQdGX1Uv

using System;
using System.Collections;
class GFG 
{
    static public void Main(String[] args)
    {
        Hashtable myhash = new Hashtable();
        myhash.Add("A1","This");
        myhash.Add("A2","is");
        myhash.Add("A3","Aayushi");
        myhash.Add("A4","Rathi.");
        Console.WriteLine("Key and Value pairs: ");
        
        foreach(DictionaryEntry ele1 in myhash)(
            Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
    }
}

