namespace Examination_2
{
    public class Rectangle: Shape2D
    {  
        //Properties
        public override double Area 
        { 
            get 
            {
                return Length*Width;
            } 
        }

        public override double Perimeter 
        { 
            get 
            {
                return 2*Length+2*Width;
            } 
        }

        //Constructor
        public Rectangle(double length, double width): base(ShapeType.Rectangle, length, width)
        {
        }
    }
}