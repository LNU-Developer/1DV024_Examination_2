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
                dynamic[] types = RandomizeObjects(type, forms, maximum, minimum);
                for (int i = 0; i<types.Length;i++) {
                    Console.WriteLine($"{types[i].ToString("R")}");
                }
            } else
            {
                throw new FormatException($"{type} must be entered as '0' or '1'");
            }  


        }
        private static dynamic RandomizeObjects(int type, int n, int maximum, int minimum) 
        {
            dynamic[] objects = new dynamic[n];
            if(type == 0) {
                for (int i = 0; i < n; i++) {
                    Random rnd = new Random();
                    int index = rnd.Next(2);
                    switch ((ShapeType)index)
                    {
                        case ShapeType.Ellipse:
                            objects[i] = new Ellipse(rnd.Next(minimum, maximum), rnd.Next(minimum, maximum));
                        break;
                        case ShapeType.Rectangle:
                            objects[i] = new Rectangle(rnd.Next(minimum, maximum), rnd.Next(minimum, maximum));
                        break;
                    }
                }
            }
            else if(type == 1) {
                for (int i = 0; i < n; i++) {
                    Random rnd = new Random();
                    int index = rnd.Next(3, 5);
                    switch ((ShapeType)index)
                    {
                        case ShapeType.Sphere:
                            objects[i] = new Sphere(rnd.Next(minimum, maximum+1));
                        break;
                        case ShapeType.Cuboid:
                            objects[i] = new Cuboid(rnd.Next(minimum, maximum+1), rnd.Next(minimum, maximum+1), rnd.Next(minimum, maximum+1));
                        break;
                        case ShapeType.Cylinder:
                            objects[i] = new Cylinder(rnd.Next(minimum, maximum+1), rnd.Next(minimum, maximum+1), rnd.Next(minimum, maximum+1));
                        break;
                    }
                }
            }
            return objects;
        }

        private static Array ToString(int[] types) 
        {
            int[] test = new int[1];
            return test;  
        }
    }
}
