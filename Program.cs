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
            string line1 = Console.ReadLine();
            int type = StringConverter.TypeSelection(line1);
            
            Console.Write("Please select how many forms you want to create (integer): ");
            string line2 = Console.ReadLine();
            int forms = StringConverter.FormsSelection(line2);
                
            Console.Write("Please select the minimum value (double): ");
            string line3 = Console.ReadLine();
            Console.Write("Please select the maximum value (double): ");
            string line4 = Console.ReadLine();
            
            double[] range = StringConverter.RangeSelection(line3, line4);
                
            dynamic[] objects = ObjectHandler.RandomizeObjects(type, forms, range[0], range[1]);
            
            List<dynamic[]> printOut = ObjectHandler.PrintOut(objects);

            if(type == 1) 
            {
                Console.WriteLine($"{"Shape".PadRight(15, ' ')} {"Length".PadRight(10, ' ')} {"Width".PadRight(10, ' ')} {"Height".PadRight(10, ' ')} {"Mantel area".PadRight(15, ' ')} {"Tot. surf. area".PadRight(18, ' ')} {"Volume".PadRight(10, ' ')}");
                for (int i = 0; i<printOut.Count;i++) {        
                    Console.WriteLine($"{printOut.ElementAt(i)[0].PadRight(15, ' ')} {printOut.ElementAt(i)[1].PadRight(10, ' ')} {printOut.ElementAt(i)[2].PadRight(10, ' ')} {printOut.ElementAt(i)[3].PadRight(10, ' ')} {printOut.ElementAt(i)[4].PadRight(15, ' ')} {printOut.ElementAt(i)[5].PadRight(18, ' ')} {printOut.ElementAt(i)[6].PadRight(10, ' ')}");
                }                  
            } 
            else 
            {
                Console.WriteLine($"{"Shape".PadRight(15, ' ')} {"Length".PadRight(10, ' ')} {"Width".PadRight(10, ' ')} {"Perimeter".PadRight(10, ' ')} {"Area".PadRight(10, ' ')}");
                for (int i = 0; i<printOut.Count;i++) { 
                    Console.WriteLine($"{printOut.ElementAt(i)[0].PadRight(15, ' ')} {printOut.ElementAt(i)[1].PadRight(10, ' ')} {printOut.ElementAt(i)[2].PadRight(10, ' ')} {printOut.ElementAt(i)[3].PadRight(10, ' ')} {printOut.ElementAt(i)[4].PadRight(10, ' ')}");
                }
            }  
        }
    }
}
