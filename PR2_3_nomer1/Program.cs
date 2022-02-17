using System;

namespace PR2_3_nomer1
{
    class Program
    {
        static void Main(string[] args)
        {
            double top1 = 0;
            double top2 = 0;
            double top3 = 0;
            try
            {
                top1 = Convert.ToDouble(Console.ReadLine());
                top2 = Convert.ToDouble(Console.ReadLine());
                top3 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите числа!");
                return;
            }

            if (top1 <= 0 || top2 <= 0 || top3 <= 0)
            {
                Console.WriteLine("Сторона треугольника не может быть меньше или равна нулю");
            }
            else if ((top1 + top2 < top3) || (top2 + top3 < top1) || (top1 + top3 < top2))
            {
                Console.WriteLine("Сумма двух сторон треугольника не может быть меньше третьей стороны");
            }
            else
            {
                if (top1 == top2 && top2 == top3 && top1 == top3)
                {
                    Console.WriteLine("Равносторонний");
                    double P = (Math.Sqrt(3) / 4) * (Math.Pow(top1, 2));
                    Console.Write("Площадь равностороннего = " + P);
                }
                else if (top1 == top2 || top2 == top3 || top1 == top3)
                {
                    double h = 0;
                    double P;
                    Console.WriteLine("Равнобедренный");
                    if (top1 == top2)
                    {
                        h = Math.Sqrt(Math.Pow(top1, 2) - (Math.Pow(top3, 2) / 4));
                        P = 0.5 * top3 * h;
                    }
                    else if (top2 == top3)
                    {
                        h = Math.Sqrt(Math.Pow(top2, 2) - (Math.Pow(top1, 2) / 4));
                        P = 0.5 * top1 * h;
                    }
                    else
                    {
                        h = Math.Sqrt(Math.Pow(top1, 2) - (Math.Pow(top2, 2) / 4));
                        P = 0.5 * top2 * h;
                    }
                    Console.Write("Площадь равнобедренного = " + P);
                }
                else if (top1 != top2 && top2 != top3 && top1 != top3)
                {
                    Console.WriteLine("Разносторонний");
                    double p_ = (top1 + top2 + top3) / 2;
                    double P = Math.Sqrt(p_ * (p_ - top1) * (p_ - top2) * (p_ - top3));
                    Console.Write("Площадь разносторонного = " + P);
                }
            }
        }
    }
}
