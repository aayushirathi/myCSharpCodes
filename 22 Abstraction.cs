using System;
namespace Demoabstraction{
  abstract class Shape{
    public abstract int area();
  }
  class Square : Shape {
    private int side;
    public Square(int x = 0)
    {
      side = x;
    }
    public override int area()
    {
      Console.Write("Area of square: ");
      return(side*side);
    }
  }
  class GFG{
    static void Main(String[] args){
      Shape sh = new Square(4);
      double result = sh.area();
      Console.Write("{0}", result);
    }
  }
}