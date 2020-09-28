using System;
class GFG {
  static void copymethod()
  { string str1 = "GeeksforGeeks";
    string str2 = "Geeks";
    Console.WriteLine("Original Strings: str1= '{0}' and str2= '{1}'", str1, str2);
    Console.WriteLine("");
    Console.WriteLine("After copy method");
    Console.WriteLine("");

    str2 = String.Copy(str1);
    Console.WriteLine("Strings are str1 = '{0}' and str2= '{1}'", str1, str2);
  }
  static public void Main()
  {
    copymethod();
  }
}