using System;

namespace Examination_2
{
    public static class ObjectHandler
    {  
        public static dynamic[] RandomizeObjects(int type, int n, int maximum, int minimum) 
        {
            dynamic[] objects = new dynamic[n];
            if(type == 0) {
                for (int i = 0; i < n; i++) {
                    Random rnd = new Random();
                    int index = rnd.Next(2);
                    switch ((ShapeType)index)
                    {
                        case ShapeType.Ellipse:
                            objects[i] = new Ellipse(rnd.Next(minimum, maximum+1), rnd.Next(minimum, maximum+1));
                        break;
                        case ShapeType.Rectangle:
                            objects[i] = new Rectangle(rnd.Next(minimum, maximum+1), rnd.Next(minimum, maximum+1));
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
        
        private static dynamic[] PrintOut(dynamic[] objects) 
        {
            dynamic[] data = new dynamic[objects.Length];
            return data;  
        }
    }
}