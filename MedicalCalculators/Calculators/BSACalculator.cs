using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCalculators.Models;

namespace MedicalCalculators.Calculators
{
    public class BSACalculator
    {
        public BSAResult Calculate(BSARequest request)
        {
            if (request.WeightKg <= 0)
                throw new ArgumentException("Вес должен быть положительным числом");

            if (request.HeightCm <= 0)
                throw new ArgumentException("Рост должен быть положительным числом");

            double bsa = Math.Sqrt((request.HeightCm * request.WeightKg) / 3600.0);

            return new BSAResult { BSA = bsa };
        }
    }
}
