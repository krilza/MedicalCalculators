using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCalculators.Models;

namespace MedicalCalculators.Calculators
{
    public class MAPCalculator
    {
        public MAPResult Calculate(MAPRequest request)
        {
            if (request.Systolic <= 0)
                throw new ArgumentException("Систолическое давление должно быть положительным числом");

            if (request.Diastolic <= 0)
                throw new ArgumentException("Диастолическое давление должно быть положительным числом");

            if (request.Systolic <= request.Diastolic)
                throw new ArgumentException("Систолическое давление должно быть больше диастолического");

            double map = request.Diastolic + (request.Systolic - request.Diastolic) / 3.0;
            string category;

            if (map < 70)
                category = "Низкое";
            else if (map <= 100)
                category = "Норма";
            else
                category = "Высокое";

            return new MAPResult { Value = map, Category = category };
        }
    }
}
