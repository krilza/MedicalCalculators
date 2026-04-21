using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCalculators.Models
{
    public class BMIResult
    {
        public double BMI { get; set; }
        public string Category { get; set; }
        public Color CategoryColor { get; set; }
        public double NormalWeightMin { get; set; }
        public double NormalWeightMax { get; set; }
    }
}
