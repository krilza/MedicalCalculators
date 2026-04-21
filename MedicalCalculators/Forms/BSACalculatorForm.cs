using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalCalculators.Calculators;
using MedicalCalculators.Models;

namespace MedicalCalculators
{
    public partial class BSACalculatorForm : Form
    {
        private BSACalculator _calculator;

        public BSACalculatorForm()
        {
            InitializeComponent();
            this.AcceptButton = calculateButton;

            _calculator = new BSACalculator();

            calculateButton.Click += CalculateBSA;
            closeButton.Click += (s, e) => this.Close();
        }
        private void CalculateBSA(object sender, EventArgs e)
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

                var request = new BSARequest
                {
                    WeightKg = double.Parse(weightTextBox.Text),
                    HeightCm = double.Parse(heightTextBox.Text)
                };

                var result = _calculator.Calculate(request);
                resultLabel.Text = $"ППТ: {result.BSA:F2} м²";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
