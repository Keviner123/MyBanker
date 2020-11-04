using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Card_Types
{
    public class DebitCard : Card
    {
        public DebitCard(string accountNumber, string nameOnCard, List<int> prefixes)
        {
            base.AccountNumber = accountNumber;
            base.NameOnCard = nameOnCard;
            base.Prefixes = prefixes;
        }
    }
}
