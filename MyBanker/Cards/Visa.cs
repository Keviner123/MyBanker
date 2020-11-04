using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class Visa : CreditCard
    {
        public Visa(string nameOnCard, string accountNumber)
        {
            this.Prefixes = new List<int>() { 4 };
            this.MinCardNoLength = 16;
            this.CardNo = base.GenerateCardNo();
            this.MinMonthValid = 60;
            this.MaxMonthValid = 60;
            base.SetExpiration();
            this.NameOnCard = nameOnCard;
            this.AccountNumber = accountNumber;
        }
    }
}
