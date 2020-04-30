namespace Examination_2
{
    public class Cuboid: Shape3D
    {
        //Constructor
        public Cuboid(double length, double width, double height): base(ShapeType.Cuboid, new Rectangle(length, width), height)
        {   
            Length = length;
            Width = width;
        }
    }
}