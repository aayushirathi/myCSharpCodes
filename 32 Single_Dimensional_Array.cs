using System;
namespace geeksforgeeks {
  class GFG {
    public static void Main(){
      string[] weekDays;
      weekDays = new string[] {"Sunday", "Monday", " Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
      foreach(string day in weekDays)
      Console.Write(" "+ day);
    }
  }
}