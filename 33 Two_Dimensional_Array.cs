using System;
namespace geeksforgeeks {
  class GFG {
    public static void Main() {
      int[, ] intarray = new int[, ]{
        {1, 2}, {3, 4}, {5, 6}, {7, 8}
      };
      int[, ] intarray_d = new int[4, 2]{
        {1, 2}, {3, 4}, {5, 6}, {7, 8}
      };
      Console.WriteLine("2D Array[0, 0]: "+ intarray[0, 0]);
      Console.WriteLine("2D Array[1, 1]: "+intarray_d[1, 1]);
    }
  }
}