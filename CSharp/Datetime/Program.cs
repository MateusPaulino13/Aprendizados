using System;
using System.Globalization;

namespace Datetime;
    internal class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Now;
        DateTime d2 = DateTime.Today;
        DateTime d3 = DateTime.UtcNow;
        DateTime d4 = new DateTime();

        Console.WriteLine(d1);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);

        //parse
        DateTime conversao = DateTime.Parse("12/01/2006 14:56:09");
        Console.WriteLine(conversao);

        //parse com formatação de data especifica
        DateTime conversaoEspecifica = DateTime.ParseExact("10-2024-04", "MM-yyyy-dd", CultureInfo.InvariantCulture);
        Console.WriteLine(conversaoEspecifica);

        Console.WriteLine($"Date: {d1.Date}");
        Console.WriteLine($"Dia: {d1.Day}");
        Console.WriteLine($"Dia da semana: {d1.DayOfWeek}");
        Console.WriteLine($"Dia do ano: {d1.DayOfYear}");
        Console.WriteLine($"Hora: {d1   .Hour}");
        Console.WriteLine($"Kind: {d1.Kind}");
        Console.WriteLine($"Minuto: {d4.Minute}");
        Console.WriteLine($"Mês: {d1.Month}");
        Console.WriteLine($"Ticks: {d1.Ticks}");
        Console.WriteLine($"Tempo do dia: {d1.TimeOfDay}");
        Console.WriteLine($"Ano: {d1.Year}");

        Console.WriteLine("//---------------------------------//");

        Console.WriteLine(d1.ToLongDateString());
        Console.WriteLine(d1.ToLongTimeString());
        Console.WriteLine(d1.ToShortDateString());
        Console.WriteLine(d1.ToShortTimeString());
        Console.WriteLine(d1.ToString("yyyy/dd-MM mm:HH:ss.fff"));

        Console.WriteLine("//---------------------------------//");

        DateTime Datadoida = DateTime.Now;
        DateTime sla = new DateTime(2011, 10, 5);
        Console.WriteLine(Datadoida.AddHours(4));
        Console.WriteLine(Datadoida.AddMinutes(13));
        Console.WriteLine(Datadoida.AddSeconds(480));
        Console.WriteLine(Datadoida.AddMonths(2));
        Console.WriteLine($"Diferença entre data: {Datadoida.Subtract(sla)}"); //ele retorna um timespan

        Console.WriteLine("//----------------------------------//");
        DateTime dd = new DateTime(2009, 12, 30, 20, 29,  9, DateTimeKind.Local);
        Console.WriteLine($"Data Local: {dd}");
        Console.WriteLine($"Data Universal: {dd.ToUniversalTime()}");

        string dataIso = dd.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        Console.WriteLine($"Padrão iso 8601: {dataIso}");
    }
}