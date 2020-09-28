Link- https://onlinegdb.com/HynO5wPSw

using System;
class GFG{
  static public void Main(){
    var myTuple1 = ValueTuple.Create();
    Console.WriteLine("HashCode of a ValueTuple with zero elements: "+ myTuple1.GetHashCode());
    var myTuple2 = ValueTuple.Create(56, 3);
    var myTuple3 = ValueTuple.Create(56, 45);
    int res = myTuple2.CompareTo(myTuple3);
    Console.WriteLine("CompareTo method result: "+ res);
  }
}