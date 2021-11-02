using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20Lesson20
{
    class Program
    {
        delegate double CircleDeligate(double a);
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите радиус R=");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                CircleDeligate circul1 = LenghtCircle;
                if (circul1 != null)
                {
                    double d = circul1(r);
                    Console.WriteLine($"Длина окружности = {d,3:f2}");
                    Console.WriteLine();
                }



                CircleDeligate circul2 = AreaCircle;
                if (circul2 != null)
                {
                    double s = circul2(r);
                    Console.WriteLine($"Площадь круга = {s,3:f2}");
                    Console.WriteLine();

                }

                CircleDeligate circul3 = VolumeBall;
                if (circul3 != null)
                {
                    double v = circul3(r);
                    Console.WriteLine($"Объем шара = {v,3:f2}");
                    Console.WriteLine();

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadKey();
        }
        static double LenghtCircle(double r)
        {
            double d = 2 * r * Math.PI;

            return d;
        }
        static double AreaCircle(double r)
        {
            double s = r * r * Math.PI;

            return s;
        }
        static double VolumeBall(double r)
        {
            double v = (4 / 3) * r * r * r * Math.PI;
            return v;
        }
    }
}
