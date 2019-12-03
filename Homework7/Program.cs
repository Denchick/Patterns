using System;
using Homework7.States;

namespace Homework7
{
    class Program
    {
        /* Необходимо реализовать поведение для копировального автомата с помощью паттерна State
         * Алгоритм работы с копировальным автоматом:
         *
         *     1. Вносим деньги
         *     2. Выбираем устройство, которое содержит информацию (флешка или wi-fi устройство)
         *     3. Выбираем документ
         *     4. Печатаем документ
         *     5. Если нужно ещё распечатать документ –> п.3
         *     6. Забираем сдачу
         * Profit! */
        static void Main(string[] args)
        {
            Demonstrate();
            // IncorrectDemonstrate();
        }

        private static void Demonstrate()
        {
            var copyMachine = new CopyMachine(10);
            copyMachine.PutMoney(5);
            copyMachine.PutMoney(15);
            copyMachine.ChooseDevice(Device.Bluetooth);
            copyMachine.ChooseDocument("document.doc");
            copyMachine.PrintDocument();
            copyMachine.ChooseDevice(Device.FlashDrive);
            copyMachine.ChooseDocument("book.pdf");
            copyMachine.PrintDocument();
        }

        private static void IncorrectDemonstrate()
        {
            var copyMachine = new CopyMachine(10);
            copyMachine.ChooseDevice(Device.Bluetooth);
            copyMachine.ChooseDocument("document.doc");
            copyMachine.PrintDocument();
            copyMachine.TakeChange();
        }
    }
}