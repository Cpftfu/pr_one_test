using System;

    public class Program
    {
        public static double ProgramCalculate(double Osn, double Stavka, double Time, int x)
        {
            if (Osn < 0)
                throw new ArgumentException("Начальная сумма должна быть неотрицательной");
            if (Stavka < 0)
                throw new ArgumentException("Процентная ставка должна быть неотрицательным числом");
            if (Time < 0)
                throw new ArgumentException("Время должно быть неотрицательным числом");
            if (x <= 0)
                throw new ArgumentException("Кол-во начислений процентов в год должно быть положительным целым числом");

            return Osn * Math.Pow(1 + (Stavka / x), x * Time);

        }

        class Test
        {
            static void Main(string[] args)
            {
                try
                {
                    double Osn = 2050;
                    double Stavka = 0.05;
                    double Time = 5;
                    int x = 8;

                    double result = Program.ProgramCalculate(Osn, Stavka, Time, x);
                    Console.WriteLine("Итоговая сумма: " + result.ToString("F2"));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
    }
