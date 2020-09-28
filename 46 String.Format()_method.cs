using System;
class Geeks {
  public static void Main(){
    int number = 10;
    string car = "BMW";
    string color = "Red";
    string str = string.Format("{0} {1} cars color is {2}" , number, car, color);
    Console.WriteLine(str);

  }
}