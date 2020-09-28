using System;
using System.Collections;
class GFG {
  public static void Main(){
    ArrayList My_array = new ArrayList();
        My_array.Add('A'); 
        My_array.Add('A'); 
        My_array.Add('Y'); 
        My_array.Add('U'); 
        My_array.Add('S'); 
        My_array.Add('H'); 
        My_array.Add('I'); 
        My_array.Add('R'); 
        My_array.Add('A'); 
        My_array.Add('T'); 
        My_array.Add('H'); 
        My_array.Add('I'); 
 foreach(var elements in My_array)
 Console.Write(elements);
 Console.WriteLine();
 My_array.Remove('A');
 foreach(var elements in My_array)
 Console.Write(elements);
 Console.WriteLine();
 My_array.RemoveAt(0);
 foreach(var elements in My_array)
 Console.Write(elements);
 Console.WriteLine();
 My_array.RemoveRange(1,3);
 foreach(var elements in My_array)
 Console.Write(elements);
 Console.WriteLine();
 My_array.Clear();
 foreach(var elements in My_array)
 Console.Write(elements);
 Console.WriteLine();
  }
}
