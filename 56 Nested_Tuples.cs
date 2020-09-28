Link- https://onlinegdb.com/HkyzsPIBw

using System;
public class GFG {
  static public void Main(String[] args){
    var My_Tuple = Tuple.Create(13,"Aayushi",57.0,1.111,'a',Tuple.Create(12,30,1,23));
    Console.WriteLine("4th Element of My_Tuple: "+ My_Tuple.Item4);
    Console.WriteLine("1st Element of My_Tuple: "+ My_Tuple.Item1);
    Console.WriteLine("Elements of nested tuple: "+ My_Tuple.Item6);
    Console.WriteLine("1st element of nested tuple: "+ My_Tuple.Item6.Item1);
    Console.WriteLine("3rd element od nested tuple: "+ My_Tuple.Item6.Item3);
  }
}