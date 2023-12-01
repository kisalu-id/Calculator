using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Rechner
{
	class Program
	{
		static void Main(string[]args)
		{
		    try 
		    {
		        Regex validateNumberRegex = new Regex("^\\d+$");
		        
		        Console.WriteLine("Enter first number and press Enter:");
                string x1 = Console.ReadLine();
                
		        Console.WriteLine("Enter second number and press Enter:");
                string x2 = Console.ReadLine();
                if(
                    (!validateNumberRegex.IsMatch(x1)) 
                    || (!validateNumberRegex.IsMatch(x2))
                 ) {
                    Console.WriteLine("Error");
                }
                
                int _x1 = int.Parse(x1); 
                int _x2 = int.Parse(x2);
                    
                Console.WriteLine("Enter operator and press Enter:");
                string opt = Console.ReadLine();
                
                switch (opt)
                {
                    case "*":
                    Console.WriteLine(_x1 * _x2);
                    break;
            	    case "-":
                    Console.WriteLine(_x1 - _x2);
                    break;
                    case "+":
                    Console.WriteLine(_x1 + _x2);
                    break;
                    case "%":
                    Console.WriteLine(String.Format("Result is {0}", _x1 % _x2));
                    break;
                    case "/":
                    if (_x2==0)
                    {
                        Console.WriteLine("Teilen durch 0 nicht möglich");
                    }
                    else
                    {
                    Console.WriteLine(_x1 / _x2);
                    }
                    break;
                    default:
                    Console.WriteLine("Error");
                    break;
                }
		    } catch
                {
                Console.WriteLine("Es gab einen Error...");
                }
		}
	}
}
