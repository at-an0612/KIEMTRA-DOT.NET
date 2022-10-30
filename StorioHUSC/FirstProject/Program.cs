using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b= 10;
            c = a + b;
            Console.WriteLine(a + "+"+ b +"+"+c);
            Console.WriteLine(String.Format("{0}+{1}={2}",a,b,c));
            Console.WriteLine($"{a}+{b}={c}");
            int n = 10;
            if (MathHUSC.IsOdd(n))
                Console.WriteLine($"{n} la so le");
            else
                Console.WriteLine($"{n} la so le");
            Console.ReadKey();
        }
    }

    class MathHUSC
    {
        ///<sumary>
        ///kiem tra mot so laf chan hay le
        ///<param name="n">So can kiem tra</param>
        ///true la so chan
        ///false la so le
        ///</returns>
        public static bool IsOdd(int n)
            {
                if(n%2 == 0) 
                    return true;
                return false;
            }
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
            x = 0; 
            y = 0;
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            x= p.x;
            y= p.y;
        }

    public double Distance()
        {
            var d= Math.Sqrt(x*x+y*y);
            return d;
        }

        public double Distance(Point p)
        {
            var d= Math.Sqrt(Math.Pow(x-p.x,2)+Math.Pow(y-p.y,2)); 
            return d;
        }

        public double Distance(Point p1,Point p2)
        {
            var d=Math.Sqrt(Math.Pow(p1.x-p2.x, 2)+Math.Pow(p1.y-p2.y,2));
            return d;
        }

    class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }

            public Circle()
            {
                Center = new Point();
                Radius = 0;
            }

            public Circle(int x)
        }
    }
}
