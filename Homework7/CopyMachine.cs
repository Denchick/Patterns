using System;
using Homework7.States;

namespace Homework7
{
    public class CopyMachine
    {
        private State _state;
        public readonly int costPerDocument = 10;
        public int loadedMoney;
        public string document;
        public Device chosenDevice;


        public CopyMachine(int costPerDocument)
        {
            _state = new WaitingMoneyState(this);
            this.costPerDocument = costPerDocument;
        }
        
        public void ChangeState(State state)
        {
            Console.WriteLine($"STATE CHANGED: from {_state.GetType().Name} to {state.GetType().Name}.");
            _state = state;
        }

        public void PutMoney(int money)
        {
            _state.HandlePutMoney(money);
        }

        public void ChooseDevice(Device device)
        {
            _state.HandleChooseDevice(device);
        }

        public void ChooseDocument(string document)
        {
            _state.HandleChooseDocument(document);
        }

        public void PrintDocument()
        {
            _state.HandlePrintDocument();
        }

        public void TakeChange()
        {
            _state.HandleTakeChange();
        }
    }
}