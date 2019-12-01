using Homework6.Banknotes;

namespace Homework6
{
    public class HundredDollarHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new HundredDollarBanknote();
        
        public HundredDollarHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class FiftyDollarHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiftyDollarBanknote();
        
        public FiftyDollarHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }

    }

    public class TwentyDollarHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new TwentyDollarBanknote();
        
        public TwentyDollarHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }

    }

    public class TenDollarHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new TenDollarBanknote();
        
        public TenDollarHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class FiveDollarHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiveDollarBanknote();
        
        public FiveDollarHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class TwoDollarHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new TwoDollarBanknote();
        
        public TwoDollarHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }
    
    public class OneDollarHandler : BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new OneDollarBanknote();
        
        public OneDollarHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }
}