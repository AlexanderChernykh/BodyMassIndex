using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите ваш рост в см.");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите ваш вес в кг.");
                var weight = Convert.ToDouble(Console.ReadLine());

                var human = new BMI(height, weight);
                Console.WriteLine(human.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Были введены неправильные данные!");
            }
          
        }
    }
}
