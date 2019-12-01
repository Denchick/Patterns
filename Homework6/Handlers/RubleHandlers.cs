using Homework6.Banknotes;

namespace Homework6.Handlers
{
    public class TenRublesHandler: BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new TenRublesBanknote();
        
        public TenRublesHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class FiftyRublesHandler: BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiftyRublesBanknote();
        
        public FiftyRublesHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class HundredRublesHandler: BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new HundredRublesBanknote();
        
        public HundredRublesHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class FiveHundredRublesHandler: BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiveHundredRublesBanknote();
        
        public FiveHundredRublesHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class ThousandRublesHandler: BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new ThousandRublesBanknote();
        
        public ThousandRublesHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }

    public class FiveThousandRublesHandler: BanknoteHandlerBase
    {
        protected override IBanknote Banknote => new FiveThousandRublesBanknote();
        
        public FiveThousandRublesHandler(BanknoteHandlerBase nextHandlerBase) : base(nextHandlerBase)
        { }
    }
}