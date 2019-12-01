using System;
using System.Linq;

namespace Homework6
{
    class Program
    {
        /*
         * Необходимо добавить банкомату возможность вывода денежных средств
         * разными валютами. Дописать цепочку обязанностей из примера
         * Example_06. Добавить каждому обработчику метод который будет
         * обналичивать переданную сумму. Стоит обратить внимание на:
         * 
         * Порядок создания цепочки
         * 
         * Возможность обналичивания переданной суммы
         * 
         * Примеры:
         * 
         * 2050 рублей = 1000x2 + 50
         * 
         * 2033$ = 100x20 + 33 - не валидная сумма =(
         */
    
        static void Main(string[] args)
        {
            // я выпилил метод Validate, т.к. не понял сути примера с ним, увы.
            
            Demonstrate(0, CurrencyType.Dollar);
            Demonstrate(1, CurrencyType.Dollar);
            Demonstrate(101, CurrencyType.Dollar);
        }

        public static void Demonstrate(uint value, CurrencyType type)
        {
            Console.Write($"Выдача {type}{value}: ");
            var bancomat = new Bancomat();
            var banknotes = bancomat.ToIssueBanknotes(value, type);
            var result = string.Join("+", banknotes.Select(b => b.ToString()));
            Console.WriteLine(result);
        }
    }
}