using System;

namespace Examination_2
{
    public abstract class Shape2D: Shape
    {  
        //Fields
        private double _length;
        private double _width;

        //Properties
        public abstract double Area { get; }

        public abstract double Perimeter { get; }
        
        public double Length 
        { 
            get 
            {
                return _length;
            }
            set
            {
                if (value < 0 )
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be above 0");
                
                _length=value;
            } 
        }

        public double Width 
        { 
            get 
            {
                return _width;
            }
            set
            {
                if (value < 0 )
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be above 0");
                
                _width=value;
            } 
        }

        //Constructor
        protected Shape2D(ShapeType shapeType, double length, double width): base(shapeType)
        {
            Length = length;
            Width = width;
        }

        //Methods
        public override string ToString()
        {
            return ToString("G");
        }
        
        public override string ToString(string format)
        {
            if (format == "G" || format == "" || format == null)
            {
                return $@"Längd: {Length}
                Bredd: {Width}
                Omkrets: {Perimeter} 
                Area: {Area}";
            }      
            else if(format == "R")
            {
                return $"{ShapeType} {Length} {Width} {Perimeter} {Area}";
            }
            else {
                throw new FormatException(
                        $"{format} must be entered as G, R, an empty string or 'null'");
            }
        }
    }
}
