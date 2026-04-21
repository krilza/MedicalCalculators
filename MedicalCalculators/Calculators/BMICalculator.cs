using MedicalCalculators.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCalculators.Calculators
{
    public class BMICalculator
    {
        public BMIResult Calculate(BMIRequest request)
        {
            if (request.WeightKg <= 0)
                throw new ArgumentException("Вес должен быть положительным числом");

            if (request.HeightCm <= 0)
                throw new ArgumentException("Рост должен быть положительным числом");

            double heightM = request.HeightCm / 100;
            double bmi = request.WeightKg / Math.Pow(heightM, 2);

            string category;
            Color categoryColor;

            if (bmi < 18.5)
            {
                category = "Недостаточный вес";
                categoryColor = Color.Orange;
            }
            else if (bmi < 25)
            {
                category = "Нормальный вес";
                categoryColor = Color.Green;
            }
            else if (bmi < 30)
            {
                category = "Избыточный вес";
                categoryColor = Color.OrangeRed;
            }
            else
            {
                category = "Ожирение";
                categoryColor = Color.Red;
            }

            double minNormalWeight = 18.5 * Math.Pow(heightM, 2);
            double maxNormalWeight = 24.9 * Math.Pow(heightM, 2);

            return new BMIResult
            {
                BMI = bmi,
                Category = category,
                CategoryColor = categoryColor,
                NormalWeightMin = minNormalWeight,
                NormalWeightMax = maxNormalWeight
            };
        }
    }
}
