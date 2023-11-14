using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfFigure.Tests
{
    // Тестирование индивидуальных методов класса Circle.
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetAreaOfCircle_Integer()
        {
            int radius = 15;
            double expected = 706.858;
            Circle instance = new(radius);

            double actual = instance.GetArea();

            Assert.AreEqual(expected, Math.Round(actual, 3), "Площадь от радиуса {0} равна {1}, ожидалось - {2}.", radius, actual, expected);
        }

        [TestMethod]
        public void GetAreaOfCircle_NotInteger()
        {
            double radius = 6.45;
            double expected = 130.698;
            Circle instance = new(radius);

            double actual = instance.GetArea();

            Assert.AreEqual(expected, Math.Round(actual, 3), "Площадь от радиуса {0} равна {1}, ожидалось - {2}.", radius, actual, expected);
        }

        [TestMethod]
        public void GetAreaOfCircle_NegativeNumber()
        {
            int radius = -10;
            double expected = 314.159;
            Circle instance = new(radius);

            double actual = instance.GetArea();

            Assert.AreEqual(expected, Math.Round(actual, 3), "Площадь от радиуса {0} равна {1}, ожидалось - {2}.", radius, actual, expected);
        }
    }
}
