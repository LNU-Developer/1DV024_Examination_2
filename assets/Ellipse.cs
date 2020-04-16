using System;

namespace Examination_2
{
    public class Ellipse: Shape2D
    {  
        //Properties
        public override double Area 
        { 
            get 
            {
                return Length/2*Width/2*Math.PI;
            } 
        }

        public override double Perimeter 
        { 
            get 
            {
                return Math.PI*(Math.Sqrt(2*Math.Pow(Length/2, 2)+2*Math.Pow(Width/2, 2)));
            } 
        }

        //Constructor
        public Ellipse(double hdiameter, double vdiameter): base(ShapeType.Rectangle, hdiameter, vdiameter)
        {
        }

        
        public Ellipse(double diameter): base(ShapeType.Rectangle, diameter, diameter)
        {
        }
    }
}