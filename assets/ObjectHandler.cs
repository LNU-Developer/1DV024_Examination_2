using System;
using System.Collections.Generic;
using System.Linq;

namespace Examination_2
{
    public static class ObjectHandler
    {  
        public static dynamic[] RandomizeObjects(int type, int n, double maximum, double minimum) 
        {
            dynamic[] objects = new dynamic[n];
            if(type == 0) {
                for (int i = 0; i < n; i++) {
                    Random rnd = new Random();
                    int index = rnd.Next(2);
                    switch ((ShapeType)index)
                    {
                        case ShapeType.Ellipse:
                            objects[i] = new Ellipse(rnd.NextDouble()* (maximum - minimum) + minimum, rnd.NextDouble()* (maximum - minimum) + minimum);
                        break;
                        case ShapeType.Rectangle:
                            objects[i] = new Rectangle(rnd.NextDouble()* (maximum - minimum) + minimum, rnd.NextDouble()* (maximum - minimum) + minimum);
                        break;
                    }
                }
            }
            else if(type == 1) {
                for (int i = 0; i < n; i++) {
                    Random rnd = new Random();
                    int index = rnd.Next(2, 5);
                    switch ((ShapeType)index)
                    {
                        case ShapeType.Sphere:
                            objects[i] = new Sphere(rnd.NextDouble()* (maximum - minimum) + minimum);
                        break;
                        case ShapeType.Cuboid:
                            objects[i] = new Cuboid(rnd.NextDouble()* (maximum - minimum) + minimum, rnd.NextDouble()* (maximum - minimum) + minimum, rnd.NextDouble()* (maximum - minimum) + minimum);
                        break;
                        case ShapeType.Cylinder:
                            objects[i] = new Cylinder(rnd.NextDouble()* (maximum - minimum) + minimum, rnd.NextDouble()* (maximum - minimum) + minimum, rnd.NextDouble()* (maximum - minimum) + minimum);
                        break;
                    }
                }
            }
            return objects;
        }
        
        public static List<dynamic[]> PrintOut(dynamic[] objects) 
        {
            List<dynamic[]> tableValues = new List<dynamic[]>();

            for (int i = 0; i<objects.Length; i++) {
                if(objects[i].is3D) { 
                    string[] stringValues = objects[i].ToString("R").Split(" ");
                    dynamic[] cleanedValues = new dynamic[] {stringValues[0], stringValues[1], stringValues[2], stringValues[3], stringValues[4], stringValues[5], double.Parse(stringValues[6])};
                    tableValues.Add(cleanedValues);
                } else {
                    string[] stringValues = objects[i].ToString("R").Split(" ");
                    dynamic[] cleanedValues = new dynamic[] {stringValues[0], stringValues[1], stringValues[2], stringValues[3], double.Parse(stringValues[4])};
                    tableValues.Add(cleanedValues);
                }
            }
            int arrayLength = tableValues.ElementAt(0).Length;
            List<dynamic[]> sortedList = tableValues.OrderBy(x => x[0]).ThenByDescending(x => x[arrayLength-1]).ToList();
            
            for (int z = 0; z< sortedList.Count; z++) {
                sortedList.ElementAt(z)[arrayLength-1] = sortedList.ElementAt(z)[arrayLength-1].ToString(); 
            }
            

            return sortedList;  
        }
    }
}