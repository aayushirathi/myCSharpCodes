using System;
namespace geeksforgeeks {
  class GFG {
    public static void Main(){
      int [][] arr1 = {
        new int[5] {1, 3, 5, 7, 9},
        new int[4] {2, 4, 6, 8}};
        for(int i=0; i<arr1.Length; i++){
          System.Console.Write("Element ["+i+"] Array: ");
          for(int j=0; j<arr1[i].Length; j++)
          Console.Write(arr1[i][j]+" ");
          Console.WriteLine();
        }
      }
    }
    }