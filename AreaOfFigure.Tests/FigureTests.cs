using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfFigure.Tests
{
    // Тестирование зависимых статических методов класса Figure.
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void FigureGetAreaOfCircle_Integer()
        {
            int radius = 15;
            double expected = 706.858;
            Circle instance = new(radius);

            double actual = Figure.GetArea(instance);

            Assert.AreEqual(expected, Math.Round(actual, 3), "Площадь от радиуса {0} равна {1}, ожидалось - {2}.", radius, actual, expected);
        }

        [TestMethod]
        public void FigureGetAreaOfRectangle_Integers()
        {
            int a = 5, b = 10;
            int expected = 50;
            Rectangle instance = new(a, b);

            double actual = Figure.GetArea(instance);

            Assert.AreEqual(expected, actual,
            "Площадь прямоугольника со сторонами {0} и {1} равна {2}, ожидалось - {3}.", a, b, actual, expected);
        }

        [TestMethod]
        public void FigureGetAreaOfTriangle_Integers()
        {
            int a = 3, b = 5, c = 6;
            double expected = 7.483;
            Triangle instance = new(a, b, c);

            double actual = Figure.GetArea(instance);

            Assert.AreEqual(expected, Math.Round(actual, 3),
            "Площадь треугольника со сторонами {0}, {1}, {2} равна {3}, ожидалось - {4}.", a, b, c, actual, expected);
        }


        [TestMethod]
        public void FigureGetArea_WrongArgument()
        {
            int argument = 123;
            int expected = -1;

            double actual = Figure.GetArea(argument);

            Assert.AreEqual(expected, actual, "Аргумент {0} привёл к значению {1}, ожидалось - {2}", argument, actual, expected);
        }
    }
}
