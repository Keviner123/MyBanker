using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class Debit : CreditCard
    {
        public Debit(string nameOnCard, string accountNumber)
        {
            this.Prefixes = new List<int>() { 2400 };
            this.MinCardNoLength = 16;
            this.CardNo = base.GenerateCardNo();
            this.NameOnCard = nameOnCard;
            this.AccountNumber = accountNumber;
        }
    }
}
