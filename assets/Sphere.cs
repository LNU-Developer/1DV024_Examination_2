using System;

namespace Examination_2
{
    public class Sphere: Shape3D
    {  
        //Properties
        public double Diameter 
        { 
            get 
            {
                return Length/2+Width/2;
            }

            set
            {
                if (value < 0 )
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be above 0");
                
                Length=value;
                Width=value;
            } 
        }


        public override double MantelArea 
        { 
            get 
            {
                return Length/2*Width/2*Math.PI*4;
            } 
        }
        
        public override double TotalSurfaceArea 
        { 
            get 
            {
                return Length/2*Width/2*Math.PI*4;
            } 
        }

        public override double Volume 
        { 
            get 
            {
                return 4*(Length/2*Width/2*Math.PI*Length/2)/3;
            } 
        }

        //Constructor
        public Sphere(double diameter): base(ShapeType.Sphere, new Ellipse(diameter, diameter), diameter)
        {
            Length = diameter;
            Width = diameter;
        }
    }
}