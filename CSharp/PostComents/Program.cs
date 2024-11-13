using PostComents.Entities;
using System;

namespace PostComents
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Incrível!");
            Comment c2 = new Comment("Muito massa!");
            Post p1 = new Post(
                DateTime.ParseExact("13/11/2024 08:39:55", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                "Boss GT1 Review Completo",
                "Review muito massa dessa pedaleira da Boss",
                34
            );

            p1.addComment(c1);
            p1.addComment(c2);

            Console.WriteLine(p1);
        }
    }
}
