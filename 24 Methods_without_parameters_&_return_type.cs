using System;
namespace ConsoleApplication1{
  class Geeks{
    static int Sum(int x, int y){
      int a = x;
      int b = y;
      int result = a+b;
      return result;
    }
    static void Main(String[] args) {
      int a = 12;
      int b = 23;
      int c = Sum(a, b);
      Console.WriteLine("The value of  the sum is "+ c);
    }
  }
}