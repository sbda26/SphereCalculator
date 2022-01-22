namespace SphereCalculator.Library
{
    public interface ICalculator
    {
        CalculatorOutput Output { get; }

        void Calculate(double value, CalculatorEnum valueType);
    }
}