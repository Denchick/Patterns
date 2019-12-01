using System;
using System.Linq;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // я выпилил метод Validate, т.к. не понял сути примера с ним, увы.
            
            // Dollars
            Demonstrate(0, CurrencyType.Dollar);
            Demonstrate(5, CurrencyType.Dollar);
            Demonstrate(188, CurrencyType.Dollar);
            
            // Euros
            Demonstrate(5, CurrencyType.Euro);
            Demonstrate(15, CurrencyType.Euro);
            Demonstrate(885, CurrencyType.Euro);
            
            // Rubles
            Demonstrate(6660, CurrencyType.Ruble);

            // Ошибки, если не получается выдать деньги
            // Demonstrate(-1, CurrencyType.Dollar);
            // Demonstrate(1, CurrencyType.Euro);
            // Demonstrate(228, CurrencyType.Ruble);
        }

        public static void Demonstrate(uint value, CurrencyType type)
        {
            Console.Write($"Выдача {value} {type}: ");
            var bancomat = new Bancomat();
            var banknotes = bancomat.ToIssueBanknotes(value, type);
            var result = string.Join(" + ", banknotes.Select(b => b.ToString()));
            Console.WriteLine(result);
        }
    }
}