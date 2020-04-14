namespace Examination_2
{
    public abstract class Shape
    {  
        //Properties
        public bool is3D 
        {
            get 
            {   
                if(ShapeType == ShapeType.Cuboid || ShapeType == ShapeType.Sphere || ShapeType == ShapeType.Cylinder)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
                
            }
        }
        
        //Automimplemented properties with public get and private set
        public ShapeType ShapeType { get; private set; }

        //Constructor
        protected Shape(ShapeType shapeType) 
        {
            ShapeType ShapeType = shapeType;
        }

        //Methods
        public abstract string ToString(string format);
    }
}
