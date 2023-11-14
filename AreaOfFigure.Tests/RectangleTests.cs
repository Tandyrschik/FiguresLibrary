using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfFigure.Tests
{
    // Тестирование индивидуальных методов класса Rectangle.
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void GetAreaOfRectangle_Integers()
        {
            int a = 5, b = 10;
            int expected = 50;
            Rectangle instance = new(a,b);

            double actual = instance.GetArea();

            Assert.AreEqual(expected, actual, 
            "Площадь прямоугольника со сторонами {0} и {1} равна {2}, ожидалось - {3}.", a, b,  actual, expected);
        }
    }
}
