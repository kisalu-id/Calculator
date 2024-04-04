using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Regex validateNumberRegex = new Regex(@"^-?\d+(?:\.\d+)?(?:,\d+)?$");

                Console.WriteLine("Enter first number and press Enter:");
                string x1 = Console.ReadLine();

                Console.WriteLine("Enter operator and press Enter:");
                string opt = Console.ReadLine();

                Console.WriteLine("Enter second number and press Enter:");
                string x2 = Console.ReadLine();
                
                if ((!validateNumberRegex.IsMatch(x1)) || (!validateNumberRegex.IsMatch(x2)))
                {
                    // Console.WriteLine("Error");
                }

                double _x1 = double.Parse(x1);
                double _x2 = double.Parse(x2);

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
                        if (_x2 == 0)
                        {
                            Console.WriteLine("Dividing on 0 is not possible");
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
            }
            catch
            {
                Console.WriteLine("There's an error...");
            }
        }
    }
}
