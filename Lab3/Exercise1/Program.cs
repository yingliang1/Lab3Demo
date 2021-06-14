using System;

namespace Exercise1
{
    abstract class Shape1
    {

        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();

    }
     class Rectangle : Shape1
    {
        public override float Area()
        {
            Console.Write("Enter Length => ");
            L = float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth => ");
            B = float.Parse(Console.ReadLine());
            return L * B;
        }

        public override float Circumference()
        {
            return 2*(L + B);
        }

    }
     class Circle : Shape1
    {
        public override float Area()
        {
            Console.Write("Enter Radius => ");
            R = float.Parse(Console.ReadLine());

            return (float)Math.PI * R * R;
        }

        public override float Circumference()
        {
            return (float)Math.PI * 2 * R;
        }

    }
    class Program
    {
        public static void Calculate(Shape1 S)
        {

            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());

        }

        static void Main(string[] args)
        {
            Shape1 s = new Rectangle();
            Calculate(s);
            
            //Console.WriteLine($"Rectangle Area is  = {s.Area()}");
            //Console.WriteLine($"Rectangle Circumference is  = {s.Circumference()}");
            Shape1 s1 = new Circle();
            Calculate(s1);
            //Console.WriteLine($"Circle Area is  = {s1.Area()}");
            //Console.WriteLine($"Circle Circumference is  = {s1.Circumference()}");
            //Console.WriteLine("Hello World!");
        }
    }
}
