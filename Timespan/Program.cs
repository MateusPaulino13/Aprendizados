using System;
using System.Globalization;

namespace Timespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan(362, 48, 13, 9, 490, 482);

            TimeSpan t3 = TimeSpan.FromDays(2.75);
            TimeSpan t4 = TimeSpan.FromHours(48.2);
            TimeSpan t5 = TimeSpan.FromMinutes(900);
            TimeSpan t6 = TimeSpan.FromSeconds(1.5);
            TimeSpan t7 = TimeSpan.FromMilliseconds(5000);
            TimeSpan t8 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t2);

            Console.WriteLine($"Dias: {t3}");
            Console.WriteLine($"Horas: {t4}");
            Console.WriteLine($"Minutos: {t5}");
            Console.WriteLine($"Segundos: {t6}");
            Console.WriteLine($"Milissegundos: {t7}");
            Console.WriteLine($"Ticks: {t8}");

            Console.WriteLine("//---------------------//");
            
            //retornam valores inteiros
            Console.WriteLine($"Dias: {t2.Days}");
            Console.WriteLine($"Minutos: {t2.Minutes}");
            Console.WriteLine($"Segundos: {t2.Seconds}");
            Console.WriteLine($"Milisegundos: {t2.Milliseconds}");
            Console.WriteLine($"Ticks: {t2.Ticks}");

            Console.WriteLine();

            //retornam valores quebrados
            Console.WriteLine($"Dias: {t2.TotalDays}");
            Console.WriteLine($"Minutos: {t2.TotalMinutes}");
            Console.WriteLine($"Segundos: {t2.TotalSeconds}");
            Console.WriteLine($"Milisegundos: {t2.TotalMilliseconds}");

            Console.WriteLine("//---------------------//");

            TimeSpan tmp = new TimeSpan(1, 20, 50);
            TimeSpan MaisTmp = new TimeSpan(0, 10, 9);

            Console.WriteLine($"Soma de TimeSpan: {tmp.Add(MaisTmp)}");
            Console.WriteLine($"Diferença de TimeSpan: {tmp.Subtract(MaisTmp)}");
            Console.WriteLine($"Multiplicação de TimeSpan: {tmp.Multiply(2.0)}"); //double
            Console.WriteLine($"Divisão de TimeSpan: {tmp.Divide(MaisTmp)}");
        }
    }
}