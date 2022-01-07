using SphereCalculator.Library;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SphereCalculator.WinForms
{
    public partial class Main : Form
    {
        private readonly char[] _validChars = { '\b', '-', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private Calculator _calculator = new Calculator();

        public Main()
        {
            InitializeComponent();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_validChars.Contains(e.KeyChar) == false || (e.KeyChar == '-' && txtValue.Text.Length > 0) || (e.KeyChar == '.' && txtValue.Text.Contains(".") == true))
                e.KeyChar = '\0';
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculatorEnum valueType = GetValueType();
            
            _calculator.Calculate(Convert.ToDouble(txtValue.Text), valueType);

            lblRadius.Text = string.Format("{0:#,##0.########}", _calculator.Radius);
            lblDiameter.Text = string.Format("{0:#,##0.########}", _calculator.Diameter);
            lblCircumference.Text = string.Format("{0:#,##0.########}", _calculator.Circumference);
            lblSurfaceArea.Text = string.Format("{0:#,##0.########}", _calculator.SurfaceArea);
            lblVolume.Text =  string.Format("{0:#,##0.########}", _calculator.Volume);
        }

        private CalculatorEnum GetValueType()
        {
            if (rbRadius.Checked == true)
                return CalculatorEnum.Radius;
            else if (rbDiameter.Checked == true)
                return CalculatorEnum.Diameter;
            else if (rbCircumference.Checked == true)
                return CalculatorEnum.Circumference;
            else if (rbSurfaceArea.Checked == true)
                return CalculatorEnum.SurfaceArea;
            else if (rbVolume.Checked == true)
                return CalculatorEnum.Volume;
            else
                throw new Exception("Invalid value type.");
        }
    }
}
