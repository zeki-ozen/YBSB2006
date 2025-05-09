public class Shape
{
    public virtual double Area() => 0;
}
public class Circle : Shape
{
    public double R;
    public override double Area() => Math.PI * R * R;
}
