public class Circle: IGeometricObject
{
    double radius=0;
    public Circle(){}
    public Circle(double radius)=> this.radius=radius;
    public double GetRadius()=> this.radius;
    public double GetPerimeter()=> 2*3.14*radius;
    public double GetArea()=> 3.14*radius*radius;
}