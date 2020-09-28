using System;
public class GFG {
  static public void Main()
  {
    Tuple<string>My_Tuple1 = new Tuple<string>("GeeksforGeeks");
    Tuple<string, string, int>My_Tuple2 = new Tuple<string, string, int>("Aayushi", "Rathi", 11);
    Tuple<int, int, int,Tuple<int>>My_Tuple3 = new Tuple<int, int, int, Tuple<int>>(1, 2, 3, new Tuple<int>(8)) ;
    Console.WriteLine(My_Tuple1);
    Console.WriteLine(My_Tuple2);
    Console.WriteLine(My_Tuple3);
    
  }
}