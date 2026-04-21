using MedicalCalculators.Calculators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalCalculators.Models;

namespace MedicalCalculators
{
    public partial class BMICalculatorForm : Form
    {
        private BMICalculator _calculator;

        public BMICalculatorForm()
        {
            InitializeComponent();
            this.AcceptButton = calculateButton;

            _calculator = new BMICalculator();

            calculateButton.Click += CalculateBMI;
            closeButton.Click += (s, e) => this.Close();
        }

        private void CalculateBMI(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(weightTextBox.Text) ||
                    string.IsNullOrWhiteSpace(heightTextBox.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var request = new BMIRequest
                {
                    WeightKg = double.Parse(weightTextBox.Text),
                    HeightCm = double.Parse(heightTextBox.Text)
                };

                var result = _calculator.Calculate(request);

                resultLabel.Text = $"ИМТ: {result.BMI:F1} кг/м²";
                categoryLabel.Text = $"Категория: {result.Category}";
                categoryLabel.ForeColor = result.CategoryColor;
                normalWeightRangeLabel.Text = $"Норма веса для вашего роста:\n" +
                    $"{result.NormalWeightMin:F1} кг - {result.NormalWeightMax:F1} кг";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
