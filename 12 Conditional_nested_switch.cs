using System; 
public class GFG  
{ 
    public static void Main(String[] args) 
    { 
        int j = 5; 
        switch (j) 
        { 
            case 5: Console.WriteLine(5); 
                    switch (j - 1) 
                   { 
                    case 4: Console.WriteLine(4); 
                            switch (j - 2) 
                          { 
                            case 3: Console.WriteLine(3); 
                                    break; 
                         } 
                    break; 
                } 
                break; 
            case 10: Console.WriteLine(10); 
                     break; 
            case 15: Console.WriteLine(15); 
                     break; 
            default: Console.WriteLine(100); 
                     break; 
        } 
  
    } 
} 