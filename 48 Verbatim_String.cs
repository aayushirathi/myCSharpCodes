using System;
public class GFG {
  static public void Main(){
    string s1 = @"\\welcome \to GeeksforGeeks \ portal  \";
    Console.WriteLine("String s1 is: {0}", s1);
    string s2 = "This is \nC# non verbatim string";
    Console.WriteLine("String s2 is: {0}", s2);
    string s3 = @"This is \n C# verbatim string";
    Console.WriteLine("string s3 is: {0}", s3);
    Console.WriteLine(@"Without tab sequence and new line character
    C             C++           Java           Python");
  }
}