using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfFigure.Tests
{
    // Тестирование индивидуальных методов класса Triangle.
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetAreaOfTriangle_Integers()
        {
            int a = 3, b = 5, c = 6;
            double expected = 7.483;
            Triangle instance = new(a, b, c);

            double actual = instance.GetArea();

            Assert.AreEqual(expected, Math.Round(actual, 3),
            "Площадь треугольника со сторонами {0}, {1}, {2} равна {3}, ожидалось - {4}.", a, b, c, actual, expected);
        }

        [TestMethod]
        public void RightTriangleCheck_Integers1()
        {
            int a = 6, b = 8, c = 10;
            bool expected = true;
            Triangle instance = new(a, b, c);

            bool actual = instance.RightTriangleCheck();

            Assert.AreEqual(expected, actual,
            "Проверка треугольника со сторонами {0}, {1}, {2} на то, является ли он правильным. Результат - {3}, ожидалось - {4}.", a, b, c, actual, expected);
        }

        [TestMethod]
        public void RightTriangleCheck_Integers2()
        {
            int a = 5, b = 5, c = 5;
            bool expected = false;
            Triangle instance = new(a, b, c);

            bool actual = instance.RightTriangleCheck();

            Assert.AreEqual(expected, actual,
            "Проверка треугольника со сторонами {0}, {1}, {2} на то, является ли он правильным. Результат - {3}, ожидалось - {4}.", a, b, c, actual, expected);
        }
    }
}
