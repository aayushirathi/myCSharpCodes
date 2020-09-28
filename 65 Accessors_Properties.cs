Link- https://onlinegdb.com/B1nn3ntBw


using System;
public class Student 
{
  private static int cnt;
  public Student()
  {
    cnt++;
  }

  public static int counter
  {
    get
    {
      return cnt;
    }
  }
}

class StudentTest 
{
  public static void Main(string[] args)
  {
    Student s1 = new Student();
    Student s2 = new Student();
    Student s3 = new Student();
    Student s4 = new Student();
 
  Console.WriteLine("Total number of students: "+ Student.counter);
  }
}