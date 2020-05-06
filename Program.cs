using System;
using System.Linq;
using System.Collections.Generic;

namespace Examination_2
{
    class Program
    {
        static void Main()
        {   
            
            Console.Write("Please select 2D or 3D forms (0/1): ");
            int type = Convert.ToInt32(Console.ReadLine());
            
            if(type == 0 || type == 1)
            {
                Console.Write("Please select how many forms you want to create (integer): ");
                int forms = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please select the minimum value (integer): ");
                int minimum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please select the maximum value (integer): ");
                int maximum = Convert.ToInt32(Console.ReadLine());
                
                dynamic[] objects = ObjectHandler.RandomizeObjects(type, forms, maximum, minimum);
                Dictionary<string, dynamic>[] printOut = ObjectHandler.PrintOut(objects);

                for (int i = 0; i<printOut.Length;i++) {
                    if(type == 1) 
                    {
                        Console.WriteLine($"{printOut[i].ElementAt(0).Value.PadRight(15, ' ')} {printOut[i].ElementAt(1).Value.PadRight(10, ' ')} {printOut[i].ElementAt(2).Value.PadRight(10, ' ')} {printOut[i].ElementAt(3).Value.PadRight(10, ' ')} {printOut[i].ElementAt(4).Value.PadRight(15, ' ')} {printOut[i].ElementAt(5).Value.PadRight(15, ' ')} {printOut[i].ElementAt(6).Value.PadRight(10, ' ')}");
                    } else 
                    {
                        Console.WriteLine($"{printOut[i].ElementAt(0).Value.PadRight(15, ' ')} {printOut[i].ElementAt(1).Value.PadRight(10, ' ')} {printOut[i].ElementAt(2).Value.PadRight(10, ' ')} {printOut[i].ElementAt(3).Value.PadRight(10, ' ')} {printOut[i].ElementAt(4).Value.PadRight(10, ' ')}");
                    }
                }
            } else
            {
                throw new FormatException($"{type} must be entered as '0' or '1'");
            }  
        }
    }
}
