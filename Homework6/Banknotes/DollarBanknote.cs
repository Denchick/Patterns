namespace Homework6.Banknotes
{
    public abstract class DollarBanknote: IBanknote
    {
        public CurrencyType Type => CurrencyType.Dollar;
        public abstract uint Value { get; }

        public override string ToString()
        {
            return $"${Value}";
        }
    }
    
    public class OneDollarBanknote: DollarBanknote
    {
        public override uint Value => 1;
    }
    
    public class TwoDollarBanknote: DollarBanknote
    {
        public override uint Value => 2;
    }
    
    public class FiveDollarBanknote: DollarBanknote
    {
        public override uint Value => 5;
    }
    
    public class TenDollarBanknote: DollarBanknote
    {
        public override uint Value => 10;
    }
    
    public class TwentyDollarBanknote: DollarBanknote
    {
        public override uint Value => 20;
    }
    
    public class FiftyDollarBanknote: DollarBanknote
    {
        public override uint Value => 50;
    }
    
    public class HundredDollarBanknote: DollarBanknote
    {
        public override uint Value => 100;
    }
}