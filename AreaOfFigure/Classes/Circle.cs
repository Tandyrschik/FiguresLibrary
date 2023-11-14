using System;
using AreaOfFigure.Interfaces;

namespace AreaOfFigure
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        /// <summary>
        /// Принимает в параметры радиус типа double, возвращает площадь в типе double.
        /// </summary>
        public double GetArea()
        {
            Area = Math.PI * (Math.Pow(Radius, 2));
            return Area;
        }
    }
}
