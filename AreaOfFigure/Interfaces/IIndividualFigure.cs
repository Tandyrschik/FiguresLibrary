namespace AreaOfFigure.Interfaces
{
    // Особенности, присущие каждой индивидуальной фигуре должны быть прописаны в этом интерфейсе и иметь реализацию в каждом индивидуальном классе.
    public interface IIndividualFigure
    {
        public double Area { get; set; }
        public double GetArea();
    }
}
