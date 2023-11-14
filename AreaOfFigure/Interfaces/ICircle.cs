namespace AreaOfFigure.Interfaces
{
    // Индивидуальные особенности каждого индивидуального типа фигуры должны быть прописаны в интерфейсе и реализованы классом.
    public interface ICircle : IIndividualFigure
    {
        public double Radius { get; set; }
    }
}
