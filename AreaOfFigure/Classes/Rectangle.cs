using System;
using AreaOfFigure.Interfaces;

namespace AreaOfFigure
{
    public class Rectangle : IRectangle
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double Area { get; set; }

        public Rectangle(double firstSide, double secondSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }
        /// <summary>
        /// Принимает в параметры две стороны прямоугольника типа double, возвращает площадь типа double.
        /// </summary>
        public double GetArea()
        {
            Area = FirstSide * SecondSide;
            return Area;
        }
    }
}
