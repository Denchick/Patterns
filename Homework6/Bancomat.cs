using System.Collections.Generic;
using Homework6.Handlers;

namespace Homework6
{
    public class Bancomat
    {
        private readonly BanknoteHandlerBase _nextHandler;

        public Bancomat()
        {
            _nextHandler = new ErrorBanknoteHandler(null);
            _nextHandler = new OneDollarHandler(_nextHandler);
            _nextHandler = new TwoDollarHandler(_nextHandler);
            _nextHandler = new FiveDollarHandler(_nextHandler);
            _nextHandler = new TenDollarHandler(_nextHandler);
            _nextHandler = new TwentyDollarHandler(_nextHandler);
            _nextHandler = new FiftyDollarHandler(_nextHandler);
            _nextHandler = new HundredDollarHandler(_nextHandler);
            _nextHandler = new FiveEuroHandler(_nextHandler);
            
            _nextHandler = new TenEuroHandler(_nextHandler);
            _nextHandler = new TwentyEuroHandler(_nextHandler);
            _nextHandler = new FiftyEuroHandler(_nextHandler);
            _nextHandler = new HundredEuroHandler(_nextHandler);
            _nextHandler = new TwoHundredEuroHandler(_nextHandler);
            _nextHandler = new FiveHundredEuroHandler(_nextHandler);

            _nextHandler = new TenRublesHandler(_nextHandler);
            _nextHandler = new FiftyRublesHandler(_nextHandler);
            _nextHandler = new HundredRublesHandler(_nextHandler);
            _nextHandler = new FiveHundredRublesHandler(_nextHandler);
            _nextHandler = new ThousandRublesHandler(_nextHandler);
            _nextHandler = new FiveThousandRublesHandler(_nextHandler);
        }

        public IEnumerable<IBanknote> ToIssueBanknotes(uint value, CurrencyType type)
        {
            return _nextHandler.ToIssueBanknotes(value, type);
        }
    }
}
