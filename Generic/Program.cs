using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>();
            account1.input<int>(1000);

            Account<string> account2 = new Account<string>();
            account2.input<string>("105а");

            Console.ReadKey();
        }

        class Account<T>
        {
            private T accountNumber { get; set; }
            private double accountBalance = 1000;
            private string accountName { get; set; }

            public void input<T>(T value)
            {
                Console.WriteLine("Введите номер счета: {0}", value);
                Console.Write("Введите баланс: ");
                Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ФИО: ");
                Convert.ToString(Console.ReadLine());
            }
        }
    }
}