using System;
using System.Collections;
class GFG {
  static public void Main() {
    ArrayList My_array = new ArrayList();
    My_array.Add(12.56);
    My_array.Add("Geeks for Geeks");
    My_array.Add(null);
    My_array.Add('G');
    My_array.Add(1235);

    foreach(var val in My_array)
    Console.WriteLine(val);
  }
}