using Homework6.Banknotes;

namespace Homework6.Handlers
{
    public class FiveEuroHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiveEuroBanknote();
        
        public FiveEuroHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class TenEuroHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new TenEuroBanknote();
        
        public TenEuroHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class TwentyEuroHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new TwentyEuroBanknote();
        
        public TwentyEuroHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class FiftyEuroHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiftyEuroBanknote();
        
        public FiftyEuroHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class HundredEuroHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new HundredEuroBanknote();
        
        public HundredEuroHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }
    
    public class TwoHundredEuroHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new TwoHundredEuroBanknote();
        
        public TwoHundredEuroHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class FiveHundredEuroHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiveHundredEuroBanknote();
        
        public FiveHundredEuroHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }
}