using System;

namespace lab1
{
    // فئة مجردة (Abstract)
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // واجهة (Interface)
    public interface IResizable
    {
        void Resize(double factor);
    }

    public class Circle : Shape, IResizable
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;

        public override double GetArea() => Math.PI * Radius * Radius;
        public void Resize(double factor) => Radius *= factor;
    }

    internal class Program
    {
        static void Main()
        {
            var c = new Circle(5);
            Console.WriteLine($"Area: {c.GetArea():F2}");
            c.Resize(2);
            Console.WriteLine($"New Area: {c.GetArea():F2}");
            Console.ReadKey();
        }
    }
}
