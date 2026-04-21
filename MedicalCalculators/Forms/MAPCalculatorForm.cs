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
    public partial class MAPCalculatorForm : Form
    {
        private MAPCalculator _calculator;

        public MAPCalculatorForm()
        {
            InitializeComponent();

            this.AcceptButton = calculateButton;

            _calculator = new MAPCalculator();

            calculateButton.Click += CalculateMAP;
            closeButton.Click += (s, e) => this.Close();
        }
        private void CalculateMAP(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(systolicTextBox.Text) ||
                    string.IsNullOrWhiteSpace(diastolicTextBox.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var request = new MAPRequest
                {
                    Systolic = double.Parse(systolicTextBox.Text),
                    Diastolic = double.Parse(diastolicTextBox.Text)
                };

                var result = _calculator.Calculate(request);
                resultLabel.Text = $"САД: {result.Value:F0} мм рт.ст. ({result.Category})";

                if (result.Category == "Низкое")
                    resultLabel.ForeColor = Color.Orange;
                else if (result.Category == "Норма")
                    resultLabel.ForeColor = Color.Green;
                else
                    resultLabel.ForeColor = Color.Red;
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
    }
}
