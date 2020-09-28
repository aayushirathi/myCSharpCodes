Link- https://onlinegdb.com/By9rQODHw

using System;
class GFG{
  int[, ] data = new int[5, 5];
  public int this[int index1, int index2]{
    get
    {
      return data[index1, index2];
    }
    set{
      data[index1, index2] = value;
    }
  }
}

class Geeks{
  public static void Main(String[] args){
    GFG abc = new GFG();
    abc[0,0] = 1;
    abc[0,1] = 2;
    abc[0,2] = 3;  
    abc[1,0] = 4;
    abc[1,1] = 5;
    abc[1,2] = 6;
    abc[2,0] = 7;
    abc[2,1] = 8;
    abc[2,2] = 9;
    
    Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", 
                                  abc[0, 0], abc[0, 1], abc[0, 2], 
                                  abc[1, 0], abc[1, 1], abc[1, 2],  
                                  abc[2, 0], abc[2, 1], abc[2, 2]); 
  }
}