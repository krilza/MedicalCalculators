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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bmiButton.Click += (s, e) => new BMICalculatorForm().ShowDialog();
            bsaButton.Click += (s, e) => new BSACalculatorForm().ShowDialog();
            mapButton.Click += (s, e) => new MAPCalculatorForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
