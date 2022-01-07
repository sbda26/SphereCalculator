namespace SphereCalculator.Library
{
    public interface ICalculator
    {
        double Circumference { get; }
        double Diameter { get; }
        double Radius { get; }
        double SurfaceArea { get; }
        double Volume { get; set; }

        void Calculate(double value, CalculatorEnum valueType);
    }
}