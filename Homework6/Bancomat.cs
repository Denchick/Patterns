using System.Collections.Generic;

namespace Homework6
{
    public class Bancomat
    {
        private readonly BanknoteHandlerBase _nextHandler;

        public Bancomat()
        {
            _nextHandler = new ErrorBanknoteHandler(null);
            _nextHandler = new OneDollarHandler(_nextHandler);
            _nextHandler = new TenDollarHandler(_nextHandler);
            _nextHandler = new FiftyDollarHandler(_nextHandler);
            _nextHandler = new HundredDollarHandler(_nextHandler);
        }

        public IEnumerable<IBanknote> ToIssueBanknotes(uint value, CurrencyType type)
        {
            return _nextHandler.ToIssueBanknotes(value, type);
        }
    }
}
