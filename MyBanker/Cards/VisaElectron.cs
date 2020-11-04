using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class VisaElectron : CreditCard
    {
        public VisaElectron(string nameOnCard, string accountNumber)
        {
            this.Prefixes = new List<int>() { 4026, 417500, 4508, 4844, 4913, 4917 };
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
