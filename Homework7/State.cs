using System;

namespace Homework7
{
    public abstract class State
    {
        protected readonly CopyMachine _machine;

        protected State(CopyMachine machine)
        {
            _machine = machine;
        }

        public virtual void HandlePutMoney(int money)
        {
            Console.WriteLine("INFO: cant put money.");
        }
        public virtual void HandleChooseDevice(Device device)
        {
            Console.WriteLine("INFO: cant choose device.");
        }
        public virtual void HandleChooseDocument(string document)
        {
            Console.WriteLine("INFO: cant choose document.");
        }
        public virtual void HandlePrintDocument()
        {
            Console.WriteLine("INFO: cant print document.");
        }
        public virtual void HandleTakeChange()
        {
            Console.WriteLine("INFO: cant take change.");
        }
    }
}