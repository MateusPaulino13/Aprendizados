using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string dayOfWeek;

            switch (day)
            {
                case 1:
                    dayOfWeek = "Domingo";
                    break;
                case 2:
                    dayOfWeek = "Segunda";
                    break;
                case 3:
                    dayOfWeek = "Terça";
                    break;
                case 4:
                    dayOfWeek = "Quarta";
                    break;
                case 5:
                    dayOfWeek = "Quinta";
                    break;
                case 6:
                    dayOfWeek = "Sexta";
                    break;
                case 7:
                    dayOfWeek = "Sabado";
                    break;
                default:
                    dayOfWeek = "Dia inválido";
                    break;
            }

            Console.WriteLine($"Dia : {dayOfWeek}");

        }
    }
}