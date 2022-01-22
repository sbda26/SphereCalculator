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
        private const double PIx4 = Math.PI * 4;
        private const double PIx4d3 = (4 / 3) * Math.PI;

        private CalculatorOutput _output;
        public CalculatorOutput Output
        {
            get
            {
                return _output;
            }
        }

        public void Calculate(double value, CalculatorEnum valueType)
        {
            _output = new();

            switch (valueType)
            {
                case CalculatorEnum.Radius:
                    _output.Radius = value;
                    CalculateDiameter();
                    CalculateCircumference();
                    CalculateSurfaceArea();
                    CalculateVolume();
                    break;
                case CalculatorEnum.Diameter:
                    _output.Diameter = value;
                    _output.Radius = _output.Diameter / 2;
                    CalculateCircumference();
                    CalculateSurfaceArea();
                    CalculateVolume();
                    break;
                case CalculatorEnum.Circumference:
                    _output.Circumference = value;
                    _output.Radius = _output.Circumference / PIx2;
                    CalculateDiameter();
                    CalculateSurfaceArea();
                    CalculateVolume();
                    break;
                case CalculatorEnum.SurfaceArea:
                    _output.SurfaceArea = value;
                    _output.Radius = Math.Sqrt(_output.SurfaceArea / PIx4);
                    CalculateDiameter();
                    CalculateCircumference();
                    CalculateVolume();
                    break;
                case CalculatorEnum.Volume:
                    _output.Volume = value;
                    _output.Radius = Math.Cbrt(_output.Volume / PIx4d3);
                    CalculateDiameter();
                    CalculateCircumference();
                    CalculateSurfaceArea();
                    break;
            }
        }

        private void CalculateDiameter() => _output.Diameter = _output.Radius * 2;
        private void CalculateCircumference() => _output.Circumference = PIx2 * _output.Radius;
        private void CalculateSurfaceArea() => _output.SurfaceArea = PIx4 * Math.Pow(_output.Radius, 2);
        private void CalculateVolume() => _output.Volume = PIx4d3 * Math.Pow(_output.Radius, 3);
    }
}
