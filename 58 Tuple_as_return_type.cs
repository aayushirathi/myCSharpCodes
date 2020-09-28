Link- https://onlinegdb.com/HJzsAvLHD

using System;
public class GFG {
    
  static public void Main(String[] args){
    var mytuple = PrintTuple();
    Console.WriteLine(mytuple.Item1);
    Console.WriteLine(mytuple.Item2);
    Console.WriteLine(mytuple.Item3);
  }
static Tuple<string, string, string>PrintTuple(){
    return Tuple.Create("I am","Aayushi", "Rathi.");
  }
}