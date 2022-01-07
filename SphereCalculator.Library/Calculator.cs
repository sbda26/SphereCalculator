using System;

namespace SphereCalculator.Library
{
    public enum CalculatorEnum
    {
        Radius,
        Diameter,
        Circumference,
        SurfaceArea,
        Volume
    }

    public class Calculator : ICalculator
    {
        // radius = ...
        // diameter = radius / 2
        // circumference = 2*pi*r
        // surface area = (4*pi)*(r^2)
        // volume = ((4/3)*pi)*(r^3)

        private const double PIx2 = Math.PI * 2;
        private const double PIx4 = PIx2 * 2;
        private const double PIx4d3 = (4 / 3) * Math.PI;

        public double Radius { get; private set; }
        public double Diameter { get; private set; }
        public double Circumference { get; private set; }
        public double SurfaceArea { get; private set; }
        public double Volume { get; set; }

        public void Calculate(double value, CalculatorEnum valueType)
        {
            switch (valueType)
            {
                case CalculatorEnum.Radius:
                    Radius = value;
                    CalculateDiameter();
                    CalculateCircumference();
                    CalculateSurfaceArea();
                    CalculateVolume();
                    break;
                case CalculatorEnum.Diameter:
                    Diameter = value;
                    Radius = Diameter / 2;
                    CalculateCircumference();
                    CalculateSurfaceArea();
                    CalculateVolume();
                    break;
                case CalculatorEnum.Circumference:
                    Circumference = value;
                    Radius = Circumference / PIx2;
                    CalculateDiameter();
                    CalculateSurfaceArea();
                    CalculateVolume();
                    break;
                case CalculatorEnum.SurfaceArea:
                    SurfaceArea = value;
                    Radius = Math.Sqrt(SurfaceArea / PIx4);
                    CalculateDiameter();
                    CalculateCircumference();
                    CalculateVolume();
                    break;
                case CalculatorEnum.Volume:
                    Volume = value;
                    Radius = Math.Pow(Volume / PIx4d3, 0.3333333333333333);
                    CalculateDiameter();
                    CalculateCircumference();
                    CalculateSurfaceArea();
                    break;
            }
        }

        private void CalculateDiameter() => Diameter = Radius * 2;
        private void CalculateCircumference() => Circumference = PIx2 * Radius;
        private void CalculateSurfaceArea() => SurfaceArea = PIx4 * Math.Pow(Radius, 2);
        private void CalculateVolume() => Volume = PIx4d3 * Math.Pow(Radius, 3);
    }
}
