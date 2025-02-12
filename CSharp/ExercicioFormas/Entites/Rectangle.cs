using ExercicioFormas.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFormas.Entites
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double widht, double height) : base(color)
        {
            Width = widht;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
