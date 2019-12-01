using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6
{
    public class ErrorBanknoteHandler: BanknoteHandlerBase
    {
        protected override IBanknote Banknote => null;

        public override IEnumerable<IBanknote> ToIssueBanknotes(uint value, CurrencyType type)
        {
            if (value == 0)
                return Enumerable.Empty<IBanknote>();
            throw new  Exception($"it is impossible to give out the rest of the amount: {type}{value}");
        }

        public ErrorBanknoteHandler(BanknoteHandlerBase nextHandler) : base(nextHandler)
        {
        }
    }
}