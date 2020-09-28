using System;
public class Geeks{
  public static void addstr(string s1, string s2, string s3){
    string result = s1+s2+s3;
    Console.WriteLine("Final string is: "+ result);
  }
  static public void Main(String[] args){
    addstr(s1: "I am ", s2:"Aayushi ", s3:"Rathi.");
  }
}