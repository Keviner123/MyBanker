using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class Maestro : CreditCard
    {
        public Maestro(string nameOnCard, string accountNumber)
        {
            this.Prefixes = new List<int>() { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            this.MinCardNoLength = 19;
            this.CardNo = base.GenerateCardNo();
            this.MinMonthValid = 68;
            this.MaxMonthValid = 68;
            base.SetExpiration();
            this.NameOnCard = nameOnCard;
            this.AccountNumber = accountNumber;
        }
    }
}
