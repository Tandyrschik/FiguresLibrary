namespace AreaOfFigure.Interfaces
{
    // Индивидуальные особенности каждого индивидуального типа фигуры должны быть прописаны в интерфейсе и реализованы классом.
    public interface ITriangle : IIndividualFigure
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
    }

}
