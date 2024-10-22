using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModule10.Task1
{
    internal class DataEnter
    {
        public static void DEnter()
        {
            Console.WriteLine("Введите знак сложения - '+'");
            char oper = Convert.ToChar(Console.ReadLine());
            if (oper != '+') throw new Exception("Ошибка ввода");
        }
    }
}
