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
                Console.Write("Please select the minimum value (double): ");
                double minimum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please select the maximum value (double): ");
                double maximum = Convert.ToDouble(Console.ReadLine());
                
                dynamic[] objects = ObjectHandler.RandomizeObjects(type, forms, maximum, minimum);
                List<dynamic[]> printOut = ObjectHandler.PrintOut(objects);

                    if(type == 1) 
                    {
                        for (int i = 0; i<printOut.Count;i++) {        
                            if(i==0)
                            {
                                Console.WriteLine($"{"Figur".PadRight(15, ' ')} {"Längd".PadRight(10, ' ')} {"Bredd".PadRight(10, ' ')} {"Höjd".PadRight(10, ' ')} {"Mantelarea".PadRight(15, ' ')} {"Begräns. area".PadRight(15, ' ')} {"Volym".PadRight(10, ' ')}");    
                            }
                            
                            Console.WriteLine($"{printOut.ElementAt(i)[0].PadRight(15, ' ')} {printOut.ElementAt(i)[1].PadRight(10, ' ')} {printOut.ElementAt(i)[2].PadRight(10, ' ')} {printOut.ElementAt(i)[3].PadRight(10, ' ')} {printOut.ElementAt(i)[4].PadRight(15, ' ')} {printOut.ElementAt(i)[5].PadRight(15, ' ')} {printOut.ElementAt(i)[6].PadRight(10, ' ')}");
                        }                  
                    } else 
                    {
                        for (int i = 0; i<printOut.Count;i++) {        
                            if(i==0)
                            {
                                Console.WriteLine($"{"Figur".PadRight(15, ' ')} {"Längd".PadRight(10, ' ')} {"Bredd".PadRight(10, ' ')} {"Omkrets".PadRight(10, ' ')} {"Area".PadRight(10, ' ')}");    
                            }
                            
                            Console.WriteLine($"{printOut.ElementAt(i)[0].PadRight(15, ' ')} {printOut.ElementAt(i)[1].PadRight(10, ' ')} {printOut.ElementAt(i)[2].PadRight(10, ' ')} {printOut.ElementAt(i)[3].PadRight(10, ' ')} {printOut.ElementAt(i)[4].PadRight(10, ' ')}");

                        }
                    }
            
            } else
            {
                throw new FormatException($"{type} must be entered as '0' or '1'");
            }  
        }
    }
}
