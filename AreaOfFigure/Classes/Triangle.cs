using System;
using AreaOfFigure.Interfaces;

namespace AreaOfFigure
{
    public class Triangle : ITriangle
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public double Area { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        /// <summary>
        /// Принимает в параметры три стороны треугольника типа double, возвращает площадь типа double.
        /// </summary>
        public double GetArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            Area = Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
            return Area;
        }

        /// <summary>   
        /// Проверяет, является ли треугольник прямоугольным по трем его сторонам.
        /// </summary>
        public bool RightTriangleCheck()
        {
            if (FirstSide > SecondSide && FirstSide > ThirdSide)
            {
                return Math.Pow(FirstSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2);
            }
            else if (SecondSide > FirstSide && SecondSide > ThirdSide)
            {
                return Math.Pow(SecondSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2);
            }
            else if (ThirdSide > FirstSide && ThirdSide > SecondSide)
            {
                return Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2);
            }
            else return false;
        }
    }
}
