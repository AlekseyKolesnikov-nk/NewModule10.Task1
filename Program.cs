using System.Net.Mail;

namespace NewModule10.Task1
{
    /// <summary>
    /// Интерфейс ICalculator
    /// </summary>
    interface ICalculator                   
    {
        double NumberOne();
        double NumberTwo();
        double Result();
    }

    /// <summary>
    /// Производный класс Calculator
    /// </summary>
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
        
        /// <summary>
        /// Ввод данных
        /// Проверка корректности ввода знака + (try/catch)
        /// Расчет
        /// Вывод на консоль
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Введите первое число");
            double x = Convert.ToDouble(Console.ReadLine());

            bool bad = true;
            while (bad)
            {
                try
                {
                    DataEnter.PlusEnter();
                    bad = false;
                }
                catch (Exception)
                {
                    Error.OnError();
                };
            }

            Console.WriteLine("Введите второе число");
            double y = Convert.ToDouble(Console.ReadLine());

            double summ = x + y;

            Calculator calc = new Calculator(x, y, summ);
            ICalculator calculator = calc;

            Console.WriteLine("\nПервое число:\t {0}", calculator.NumberOne());
            Console.WriteLine("Второе число:\t {0}", calculator.NumberTwo());
            Console.WriteLine("Сумма чисел:\t {0}", calculator.Result());
        }
    }
}
