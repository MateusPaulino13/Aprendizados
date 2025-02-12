using System;
using System.Globalization;
using ExercicioFormas.Entites;
using ExercicioFormas.Entites.Enums;

namespace MyApp
{
    class  ExercicioFormas
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                string color = Console.ReadLine();

                if (shapeType == 'r' || shapeType == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Rectangle(Enum.Parse<Color>(color), width, height));
                }
                else if(shapeType == 'c' || shapeType == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(Enum.Parse<Color>(color), radius));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");

            foreach (Shape sp in shapes)
            {
                Console.WriteLine();
                Console.WriteLine(sp.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}