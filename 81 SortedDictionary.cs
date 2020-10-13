Link- https://onlinegdb.com/HJkEwMkLw


using System;
using System.Collections.Generic;
class GFG 
{
    static public void Main()
    {
      SortedDictionary<int, string> My_sdict = new SortedDictionary<int, string>();
      My_sdict.Add(004, "ABC");
      My_sdict.Add(001, "BCD");
      My_sdict.Add(003, "CDE");
      My_sdict.Add(2, "DEF");
      
      foreach(KeyValuePair<int, string> pair in My_sdict)
      {
          Console.WriteLine("Rank: {0} and Name: {1}", pair.Key, pair.Value);
      }
    }

   

}
