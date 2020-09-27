using System;
class Geeks{
  static string sub = null;
  static void displaysubject(string sub1){
    if(sub1 == null)
    throw new NullReferenceException("Exception Message");
  }
  static void Main(String[] args){
    try{
      displaysubject(sub);
    }
    catch(Exception Exp){
      Console.WriteLine(Exp.Message);
    }
  }
}