using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6
{
    public abstract class BanknoteHandlerBase
    {
        protected abstract IBanknote Banknote { get; }
        private readonly BanknoteHandlerBase _nextHandler;

        protected BanknoteHandlerBase(BanknoteHandlerBase nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual IEnumerable<IBanknote> ToIssueBanknotes(uint value, CurrencyType type)
        {
            if (value == 0)
                return Enumerable.Empty<IBanknote>();
            if (type != Banknote.Type)
                return _nextHandler.ToIssueBanknotes(value, type);
            var howManyTimes = (int)value / (int)Banknote.Value; // Опасное место, понимаю
            return Enumerable.Repeat(Banknote, howManyTimes)
                .Concat(_nextHandler.ToIssueBanknotes(value % Banknote.Value, type));
        }

//        public virtual bool Validate(string banknote)
//        {
//            return _nextHandler != null && _nextHandler.Validate(banknote);
//        }
    }
}