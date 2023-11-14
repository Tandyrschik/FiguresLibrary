using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfFigure.Tests
{
    // ������������ �������������� ������� ������ Rectangle.
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
            "������� �������������� �� ��������� {0} � {1} ����� {2}, ��������� - {3}.", a, b,  actual, expected);
        }
    }
}
