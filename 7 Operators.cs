using System; 
namespace Arithmetic 
{ 
    class GFG 
    { 
        static void Main(string[] args) 
        { 
              
            int result; 
            int x = 10, y = 5; 

            result = (x + y); 
            Console.WriteLine("Addition Operator: " + result); 
              
            result = (x - y); 
            Console.WriteLine("Subtraction Operator: " + result); 
              
            result = (x * y); 
            Console.WriteLine("Multiplication Operator: "+ result); 
              
            result = (x / y); 
            Console.WriteLine("Division Operator: " + result); 
              
            result = (x % y); 
            Console.WriteLine("Modulo Operator: " + result); 
        } 
    } 
} 