namespace Homework6.Banknotes
{
    public abstract class EuroBanknote: IBanknote
    {
        public CurrencyType Type => CurrencyType.Euro;
        public abstract uint Value { get; }

        public override string ToString()
        {
            return $"{Value}EU";
        }
    }

    public class FiveEuroBanknote: EuroBanknote
    {
        public override uint Value => 5;
    }
    
    public class TenEuroBanknote: EuroBanknote
    {
        public override uint Value => 10;
    }
    
    public class TwentyEuroBanknote: EuroBanknote
    {
        public override uint Value => 20;
    }
    
    public class FiftyEuroBanknote: EuroBanknote
    {
        public override uint Value => 50;
    }
    
    public class HundredEuroBanknote: EuroBanknote
    {
        public override uint Value => 100;
    }
    
    public class TwoHundredEuroBanknote: EuroBanknote
    {
        public override uint Value => 200;
    }
    
    public class FiveHundredEuroBanknote: EuroBanknote
    {
        public override uint Value => 500;
    }
}