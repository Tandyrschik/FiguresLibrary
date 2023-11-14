namespace AreaOfFigure.Interfaces
{
    // Особенности абстрактаного класса Figure должны быть прописаны в данном интерфейсе и быть реализованы самим классом.
    public interface IBaseFigure
    {
        public static double GetArea(dynamic figure)
        {
                return figure.GetArea();
        }
    }
}
