using System;
using AreaOfFigure.Interfaces;
using Microsoft.CSharp.RuntimeBinder;

namespace AreaOfFigure
{
    // 1. Это решение подразумевает использование класса Figure лишь для вызова общих операций с индивидуальными фигурами (Circle, Rectangle, Triangle и проч.)
    // без знания конкретного типа фигуры.
    // 2. У индивидуальных фигур остаётся возможность вызова общих функций и индивидуальных функций.
    // 3. Тесты написаны отдельно для класса Figure и для каждого индивидуального класса.
    public abstract class Figure : IBaseFigure
    {
        /// <summary>   
        /// Принимает экземпляр фигуры в параметры и возвращает площадь фигуры типа double, в ином случае возвращает -1.
        /// </summary>
        public static double GetArea(dynamic figure) // Второй вариант решения: вместо dynamic можно использовать любой объект,
                                                     // имплементирующий интерфейс IIndividualFigure ---> GetArea(IIndividualFigure figure).
        {
            try // Исключение на случай, если в метод попадёт что-то, что не должно попасть.
            {
                return figure.GetArea();
            }
            catch (RuntimeBinderException)
            {
                return -1;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
