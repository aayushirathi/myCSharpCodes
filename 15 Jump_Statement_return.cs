using System;
class Geeks{
  static int Addition(int a){
    int addition = a+a;
    return addition;
  }
  static public void Main(){
  int number = 2;
  int result = Addition(number);
  Console.WriteLine("The addition is {0}", result);
  }
}