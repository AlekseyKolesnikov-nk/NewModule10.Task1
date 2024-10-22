using System.Net.Mail;

namespace NewModule10.Task1
{
     interface ICalculator                   
    {
        double NumberOne();
        double NumberTwo();
        double Result();
    }

    public class Calculator : ICalculator          
    {
        double numberOne;
        double numberTwo;
        double resultInches;

        Calculator(double numOne, double numTwo, double result)
        {
            numberOne = numOne;
            numberTwo = numTwo;
            resultInches = result;
        }
        double ICalculator.NumberOne()
        {
            return numberOne;
        }
        double ICalculator.NumberTwo()
        {
            return numberTwo;
        }

        double ICalculator.Result()
        {
            return resultInches;
        }

        public static void Main()
        {
            Console.WriteLine("Введите первое число");
            double x = Convert.ToDouble(Console.ReadLine());

            bool bad = true;
            while (bad)
            {
                try
                {
                    DataEnter.DEnter();
                    bad = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка ввода");
                };
            }

            Console.WriteLine("Введите второе число");
            double y = Convert.ToDouble(Console.ReadLine());

            double summ = x + y;

            Calculator calc = new Calculator(x, y, summ);
            ICalculator calculator = calc;

            Console.WriteLine("Первое число: {0}", calculator.NumberOne());
            Console.WriteLine("Второе число: {0}", calculator.NumberTwo());
            Console.WriteLine("Сумма чисел: {0}", calculator.Result());
        }
    }
}
