using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080720
{
    class Program
    {
        //public const int MAX_ROW = 3;
        //static class Shape
        //{
        //    public static  void CalcArea()
        //    {

        //    }
        //}
        //static class Triangle : Shape
        //{

        //}

        static class Math_Utility
        {
            public static string m_calc_level = "Simple";
           public static int Add(int x, int y)
            {
                return x + y; 
            }
            public static int Sub(int x, int y)
            {
                return x - y;
            }
        }
        class Data
        {
            public int m_x = 3;
        }
        class Circle
        {
            public double m_radius;
            public const double m_pie = 3.14; // auto static
            public const string name = "ziv";

            public Circle(double m_radius)
            {
                this.m_radius = m_radius;
            }

            public double GetArea()
            {

                double result = Math.Pow(m_radius, 2) * Circle.m_pie;
                return result;
            }

            public override string ToString()
            {
                return $"[{base.ToString()}] {m_radius} pie:{Circle.m_pie} area:{GetArea()}";
            }

            public static double GetPiePower2()
            {
                // static context / methods CANNOT access non-static fields and methods
                //Console.WriteLine((TosString());
                //return m_radius;
                //Console.WriteLine(this.radius);
                return m_pie * m_pie;
            }

            // utility method
            public static double CalcMyHekefWithRadius(double radius)
            {
                return 2 * m_pie * radius;
            }

            public static void PrintCircleAreaFormula()
            {
                Console.WriteLine("pie * radius ^ 2");
            }
        }
        class Quote
        {
            private readonly int m_price;
            public Quote(int price)
            {
                m_price = price;
            }
        }
        class Transaction
        {
            // readonly field is same as const
            // but is initialized in the ctor code. now after!!!!!!!!
            // in contrary to const, it is instance field
            public readonly DateTime m_time;// = DateTime.Now;
            public int x = 10;
            public long m_amount;
            public const long MAX_AMOUNT = 1_000_000;

            public Transaction(long m_amount)
            {
                if (CheckIfOverMax(m_amount))
                {
                    Console.WriteLine("Transaction denied...");
                }
                else
                {
                    this.m_amount = m_amount;
                }
                x = 11;
                m_time = DateTime.Now;
            }

            public static bool CheckIfOverMax(long amount)
            {
                if (Math.Abs(amount) > MAX_AMOUNT)
                    return true;
                else
                    return false;
            }

            public static void PrintOptions()
            {
                Console.WriteLine("Transaction options:");
                Console.WriteLine("1. deposit");
                Console.WriteLine("2. withdraw");
            }
        }

        static void Main(string[] args)
        {
            Circle.PrintCircleAreaFormula();
            Console.WriteLine(Math_Utility.Add(2, 2));
            Console.WriteLine(Math_Utility.m_calc_level);

            Console.WriteLine(Circle.CalcMyHekefWithRadius(9));
            //Transaction tr = new Transaction(1);
            Transaction.PrintOptions();

            Transaction tr1 = new Transaction(-1000);
            //tr1.m_time = DateTime.Now.AddYears(100);

            Circle t = new Circle(10);
            Console.WriteLine(Circle.m_pie); // 3.14
            //Circle.m_pie = 8;
            Console.WriteLine(Circle.m_pie); // 8
            //t.GetPiePower2();

            Circle.GetPiePower2();

            // Circle (static) = new Circle
            //Circle.m_pie = 4.5;
            Console.WriteLine(Circle.m_pie);

            Circle cc1 = new Circle(1);
            Circle cc2 = new Circle(2);

            object o = new object();

            bool res =  Equals(cc1, cc2);
            ReferenceEquals(cc1, cc2);

            Console.WriteLine(res);

            Random r = new Random();
            Circle[] circle_array = new Circle[1000];
            for (int i = 0; i < circle_array.Length; i++)
            {
                circle_array[i] = new Circle(r.NextDouble() * r.Next(1, 100));
            }

            string user_input = Console.ReadLine();

            int x12 = Convert.ToInt32(user_input);
            Console.WriteLine(circle_array[0]);

            

            Circle c1 = new Circle(4.8);
            //c1.

            //c1.m_pie = 4;
            Console.WriteLine(c1);
            Circle c2 = new Circle(7.6);
            //c1.m_pie = 4;
            Console.WriteLine(c2);
        }
    }
}
