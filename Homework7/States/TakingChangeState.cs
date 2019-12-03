using System;

namespace Homework7.States
{
    public class TakingChangeState : State
    {
        public TakingChangeState(CopyMachine machine) : base(machine)
        {
        }

        public override void HandleTakeChange()
        {
            if (_machine.loadedMoney > 0)
                Console.WriteLine($"INFO: Taking out {_machine.loadedMoney} change.");
            Console.WriteLine("INFO: No change");
            _machine.loadedMoney = 0;
        }
    }
}