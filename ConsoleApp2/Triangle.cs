using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TriangleEntity
{
    public class Triangle
    {
        public double sideA { get; }
        public double sideB { get; }
        public double sideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Значения сторон должны быть положительными числами.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует.");
            }

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
    }
}
