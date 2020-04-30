using System;

namespace Examination_2
{
    public abstract class Shape3D: Shape
    {  
        //Fields
        private protected Shape2D _baseShape;
        private double _height;

        //Properties
        public virtual double MantelArea 
        { 
            get 
            {
                return _baseShape.Perimeter*Height;
            } 
        }

        public virtual double TotalSurfaceArea 
        { 
            get 
            {
                return MantelArea+2*_baseShape.Area;
            } 
        }
        
        public virtual double Volume 
        { 
            get 
            {
                return _baseShape.Area*Height;
            } 
        }

        public double Width { get; set; }

        public double Length { get; set; }
        
        public double Height 
        { 
            get 
            {
                return _height;
            }
            set
            {
                if (value < 0 )
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be above 0");
                
                _height=value;
            } 
        }

        //Constructor
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height): base(shapeType)
        {
            Height = height;
            _baseShape = baseShape;
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
                return $@"
                Längd: {Length}
                Bredd: {Width}
                Höjd: {Height}
                Mantelarea: {MantelArea}
                Begränsningsarea: {TotalSurfaceArea}
                Volym: {Volume}
                ";
            }      
            else if(format == "R")
            {
                return $"{ShapeType} {Length} {Width} {MantelArea} {TotalSurfaceArea} {Volume}";
            }
            else {
                throw new FormatException(
                        $"{format} must be entered as G, R, an empty string or 'null'");
            }
        }
    }
}