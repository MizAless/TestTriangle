using System;
using TriangleEntity;

namespace TriangleLibrary
{
    public static class TriangleClassifier
    {
        public static TriangleType ClassifyTriangle(Triangle triangle)
        {

            double squareA = triangle.sideA * triangle.sideA;
            double squareB = triangle.sideB * triangle.sideB;
            double squareC = triangle.sideC * triangle.sideC;

            if (squareA + squareB == squareC || squareA + squareC == squareB || squareB + squareC == squareA)
            {
                return TriangleType.RightTriangle;
            }
            else if (squareA + squareB < squareC || squareA + squareC < squareB || squareB + squareC < squareA)
            {
                return TriangleType.ObtuseTriangle;
            }
            else
            {
                return TriangleType.AcuteTriangle; 
            }
        }
    }

    public enum TriangleType
    {
        AcuteTriangle,   // остроугольный 
        RightTriangle,   // прямоугольный 
        ObtuseTriangle   // тупоугольный 
    }
}