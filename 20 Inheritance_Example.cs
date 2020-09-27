using System;
namespace ConsoleApplication1{
  class GFG{
     public string name;
     public string subject;

     public void readers(string name, string subject){
       this.name = name;
       this.subject = subject;
       Console.WriteLine("Myself: "+ name);
       Console.WriteLine("My favourite subject is: "+ subject);
     }
  }
  class GeeksForGeeks : GFG {
    public GeeksForGeeks(){
      Console.WriteLine("Geeks for Geeks");
    }
  }
  class Sudo {
    static void Main(String[] args){
       GeeksForGeeks g = new GeeksForGeeks();
       g.readers("Aayushi", "C#");
    }
  }
}