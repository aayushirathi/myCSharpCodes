Link- https://onlinegdb.com/BygsWkRYHw


using System;
public class Student 
{
  
  public string Name
  {
    get
    {
      return name;
    }
    set{
      name = value;
    }
  }
  public string name;
}

class TestStudent 
{
  public static void Main(String[] args)
  {
    Student s = new Student();
    s.Name = "GFG";
    Console.WriteLine("Name: "+s.Name);
    Console.WriteLine(s.name);
    
  }
}