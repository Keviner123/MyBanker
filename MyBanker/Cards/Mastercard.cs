using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class Mastercard : CreditCard
    {
        public Mastercard(string nameOnCard, string accountNumber)
        {
            this.Prefixes = new List<int>() { 51, 52, 53, 54, 55 };
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
