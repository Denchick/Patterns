using System;

namespace Homework7.States
{
    public class PrintSetupState: State
    {
        public PrintSetupState(CopyMachine machine) : base(machine)
        {
        }

        public override void HandleChooseDevice(Device device)
        {
            _machine.chosenDevice = device;
            TryMoveToNextState();
        }

        public override void HandleChooseDocument(string document)
        {
            _machine.document = document;
            TryMoveToNextState();
        }

        private void TryMoveToNextState()
        {
            if (_machine.chosenDevice == Device.None || _machine.document is null)
                return;
            Console.WriteLine("INFO: device and document are chosen.");
            _machine.ChangeState(new PrintingState(_machine));
            
        }
    }
}