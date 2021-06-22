using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class BMI
    {
        public double HumanHeight { get; set; }
        public double HumanWeight { get; set; }

        public BMI(double humanHeight, double humanWeight)
        {
            if (humanHeight>0)
            {
                HumanHeight = humanHeight;
            }
            else
            {
                throw new ArgumentException("Аргумент не может быть меньше 0");
            }

            if (humanHeight > 0)
            {
                HumanWeight = humanWeight;
            }
            else
            {
                throw new ArgumentException("Аргумент не может быть меньше 0");
            }
        }

        private double СalculationBodyMassIndex()
        {
            double bmi = HumanWeight / Math.Pow((HumanHeight / 100),2);
            return bmi;
        }

        private static string DescriptionBodyMassIndex(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Ниже нормального";

            }else if (bmi>=18.5 && bmi<25)
            {
                return "Норма";
            }
            return "Выше нормального";
        }

        public override string ToString()
        {
            double bmi = СalculationBodyMassIndex();
            string descriptiondmi = DescriptionBodyMassIndex(bmi);
            return $"ИМТ={Math.Round(bmi,2)} - {descriptiondmi}";
        }
    }
}
