namespace Homework6.Banknotes
{
    public abstract class RubleBanknote: IBanknote
    {
        public CurrencyType Type => CurrencyType.Ruble;
        public abstract uint Value { get; }

        public override string ToString()
        {
            return $"{Value}RUB";
        }
    }

    public class TenRublesBanknote : RubleBanknote
    {
        public override uint Value => 10;
    }
    
    public class FiftyRublesBanknote : RubleBanknote
    {
        public override uint Value => 50;
    }
    
    public class HundredRublesBanknote : RubleBanknote
    {
        public override uint Value => 100;
    }
    
    public class FiveHundredRublesBanknote : RubleBanknote
    {
        public override uint Value => 500;
    }
    
    public class ThousandRublesBanknote : RubleBanknote
    {
        public override uint Value => 1000;
    }
    
    public class FiveThousandRublesBanknote : RubleBanknote
    {
        public override uint Value => 5000;
    }
}