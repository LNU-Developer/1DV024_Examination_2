using System;
using System.Collections.Generic;

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
        
        public static Dictionary<string, string>[] PrintOut(dynamic[] objects) 
        {
            Dictionary<string, string>[] tableValues = new Dictionary<string, string>[objects.Length+1];   

                for (int i = 0; i<objects.Length; i++) {
                if(objects[i].is3D) {
                    tableValues[0] = new Dictionary<string, string>();
                    tableValues[0].Add("Figur", "Figur");
                    tableValues[0].Add("Längd", "Längd");
                    tableValues[0].Add("Bredd", "Bredd");
                    tableValues[0].Add("Höjd", "Höjd");
                    tableValues[0].Add("Mantelarea", "Mantelarea");
                    tableValues[0].Add("Begräns. area", "Begräns. area");
                    tableValues[0].Add("Volym", "Volym");
                } else {
                    tableValues[0] = new Dictionary<string, string>();
                    tableValues[0].Add("Figur", "Figur");
                    tableValues[0].Add("Längd", "Längd");
                    tableValues[0].Add("Bredd", "Bredd");
                    tableValues[0].Add("Omkrets", "Omkrets");
                    tableValues[0].Add("Area", "Area");
                }
            }

            for (int i = 1; i<objects.Length+1; i++) {
                if(objects[i-1].is3D) {
                    string[] split = objects[i-1].ToString("R").Split(" ");
                    tableValues[i] = new Dictionary<string, string>();
                    tableValues[i].Add("Figur", split[0]);
                    tableValues[i].Add("Längd", split[1]);
                    tableValues[i].Add("Bredd", split[2]);
                    tableValues[i].Add("Höjd", split[3]);
                    tableValues[i].Add("Mantelarea", split[4]);
                    tableValues[i].Add("Begräns. area", split[5]);
                    tableValues[i].Add("Volym", split[6]);
                } else {
                    string[] split = objects[i-1].ToString("R").Split(" ");
                    tableValues[i] = new Dictionary<string, string>();
                    tableValues[i].Add("Figur", split[0]);
                    tableValues[i].Add("Längd", split[1]);
                    tableValues[i].Add("Bredd", split[2]);
                    tableValues[i].Add("Omkrets", split[3]);
                    tableValues[i].Add("Area", split[4]);
                }
            }
            return tableValues;  
        }
    }
}