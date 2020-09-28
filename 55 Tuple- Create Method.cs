using System;
public class GFG {
  static public void Main()
  {
    var My_Tuple1 = Tuple.Create("GeeksforGeeks");
    var My_Tuple2 = Tuple.Create(12,13,14,15);
    var My_Tuple3 = Tuple.Create(1, "Geeks", 0.1, 'A');
    Console.WriteLine(My_Tuple1);
    Console.WriteLine(My_Tuple2.Item1);
    Console.WriteLine(My_Tuple3.Item4);
  }
}