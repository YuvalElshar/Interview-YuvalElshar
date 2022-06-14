//Given an instance Circle of the following class:

public sealed class Circle
{
    public Circle(double r)
    {
        radius = r;
    }

    private double radius;

    public double Calculate(Func<double, double> op)
    {
        return op(radius);
    }
}

public class Program
{
    public static void Main()
    {
        Circle c = new Circle(5);
        Func<double, double> op = delegate (double radius) { return 2 * Math.PI * radius; };

        double circumference = Math.Round(c.Calculate(op),3);
        Console.WriteLine("Circle Circumference: " + circumference);

        double area =  Math.Round( c.GetArea(),3);
        Console.WriteLine("Circle Area: " + area);
    }
}

static class MyExtensions
{
    public static double GetArea(this Circle c)
    {
        Func<double, double> op = delegate (double radius) { return radius * radius * Math.PI; };
        return c.Calculate(op);
    }
}
//a)	write code to calculate the circumference of the circle, without modifying the Circle class itself.
//b)	Write code implements method GetArea(), without modifying the Circle class itself:
//	Circle c=new Circle(5);
//	Double area = c.GetArea()
