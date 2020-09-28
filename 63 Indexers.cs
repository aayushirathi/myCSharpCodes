Link- https://onlinegdb.com/ryTbRPPSv


using System;
class IndexerCreation{
  private string[] val = new string[3];
  public string this[int index]{
    get
    {
      return val[index];
    }
    set
    {
    val[index] = value;
    }
  }
}

class main{
  public static void Main(){
    IndexerCreation ic = new IndexerCreation();
    ic[0]= "I";
    ic[1]= "am";
    ic[2]= "Aayushi Rathi.";
    Console.Write("Printing values stored in objects used as arrays\n");

    Console.WriteLine("First value: "+ ic[0]);
    Console.WriteLine("Second value: "+ ic[1]);
    Console.WriteLine("Third value: "+ ic[2]);

  }
}
