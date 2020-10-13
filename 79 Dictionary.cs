Link-  https://onlinegdb.com/B1bsIwiHD

using System;
using System.Collections.Generic;
class GFG
{
    static public void Main()
    {
        Dictionary<int, string>Mydict = new Dictionary<int, string>();
        Mydict.Add(1,"Hi");
        Mydict.Add(2,"I am");
        Mydict.Add(3,"Aayushi");
        Mydict.Add(4,"Rathi");
        
        foreach(KeyValuePair<int, string> ele in Mydict)
        {
            Console.WriteLine("{0} is {1}", ele.Key, ele.Value);
        }
    }
}