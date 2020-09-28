using System; 
public class DemoEncap { 
    private String studentName; 
    private int studentAge; 

    public String Name
    {
      get
      {
       return studentName;
      }
      set 
      {
        studentName = value;
      }
    }
    public int Age{
      get
      {
        return studentAge;
      }
      set
      {
        studentAge = value;
      }
    }
}
class GFG{
  static public void Main(){
    DemoEncap obj = new DemoEncap();
    obj.Name = "Aayushi";
    obj.Age = 23;
    Console.WriteLine("Name: "+ obj.Name);
    Console.WriteLine("Age: "+obj.Age);
  }

}