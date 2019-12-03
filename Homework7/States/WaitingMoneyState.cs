using System;

namespace Homework7.States
{
    public class WaitingMoneyState: State
    {
        public WaitingMoneyState(CopyMachine machine) : base(machine)
        {
        }
        
        public override void HandlePutMoney(int money)
        {
            if (!TryAddMoney(money) || _machine.loadedMoney < _machine.costPerDocument)
                return;
            Console.WriteLine("INFO: Got enough money for printing");
            _machine.ChangeState(new PrintSetupState(_machine));
        }
        
        private bool TryAddMoney(int money)
        {
            if (money < 0)
                return false;
            _machine.loadedMoney += money;
            return true;
        }
    }
}