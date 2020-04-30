namespace Examination_2
{
    public class Cylinder: Shape3D
    {
        //Constructor
        public Cylinder(double hdiameter, double vdiameter, double height): base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        {   
            Length = hdiameter;
            Width = vdiameter;
        }
    }
}