using System;

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
                
                dynamic[] types = ObjectHandler.RandomizeObjects(type, forms, maximum, minimum);

                for (int i = 0; i<types.Length;i++) {
                    Console.WriteLine($"{types[i].ToString("R")}");
                    Console.WriteLine(types[i].is3D);
                }
            
            } else
            {
                throw new FormatException($"{type} must be entered as '0' or '1'");
            }  
        }
    }
}
