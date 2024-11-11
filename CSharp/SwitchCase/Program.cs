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

            //expressão simplificada
            string dayOfWeek2 = day switch
            {
                1 => "Domingo",
                2 => "Segunda",
                3 => "Terça",
                4 => "Quarta",
                5 => "Quinta",
                6 => "Sexta",
                7 => "Sabado",
                _ => "Dia inválido"
            };

            Console.WriteLine(dayOfWeek2);

            Console.WriteLine($"Dia : {dayOfWeek}");

        }
    }
}