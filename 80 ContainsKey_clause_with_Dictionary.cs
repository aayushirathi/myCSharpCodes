Link- https://onlinegdb.com/HkiKVz1ID

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
        
if(Mydict.ContainsKey(4)==true)
{
    Console.WriteLine("Key is found.");
}
else
{
    Console.WriteLine("Key is not found.");
}

if(Mydict.ContainsValue("Aayushi")==true)
{
    Console.WriteLine("Value is found.");
}
else
{
    Console.WriteLine("Value is not found.");
}

}
}