using System;
using System.Threading;

namespace Homework7.States
{
    public class PrintingState : State
    {
        public PrintingState(CopyMachine machine) : base(machine)
        {
        }
        
        public override void HandlePrintDocument()
        {
            Print();
            Console.Write("Would you print another document? (yes or no): ");
            var wouldPrintAnotherDocument = Console.ReadLine().ToLowerInvariant().Contains("yes");
            _machine.ChangeState(GetNextState(wouldPrintAnotherDocument));
        }

        private State GetNextState(bool wouldPrintAnotherDocument)
        {
            if (!wouldPrintAnotherDocument)
            {
                Console.WriteLine("INFO: user wants change.");
                return new TakingChangeState(_machine);   
            }

            if (_machine.loadedMoney < _machine.costPerDocument)
            {
                Console.WriteLine("INFO: user doesnt have enough money for printing another document.");
                return new WaitingMoneyState(_machine);
            }
            Console.WriteLine("INFO: Setting up another print.");
            return new PrintSetupState(_machine);
        }

        private void Print()
        {
            Console.Write("Printing document... ");
            Thread.Sleep(2000);
            _machine.document = null;
            _machine.chosenDevice = Device.None;
            _machine.loadedMoney -= _machine.costPerDocument;
            Console.WriteLine("Done.");
        }
    }
}