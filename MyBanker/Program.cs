using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBanker.Card_Types;
using MyBanker.Cards;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CreditCard> Cards = new List<CreditCard>()
            {
                new Debit("Frederikke C. Søndergaard", "2405872229"),
                new Maestro("Frederik M. Bach", "2101410636"),
                new Mastercard("Mike A. Kristiansen", "1412501388"),
                new Visa("Peter J. Lauritsen", "0908009290"),
                new VisaElectron("Gustav I. Mortensen", "2808431044")
            };

            foreach (CreditCard Card in Cards)
            {
                Card.PrettyPrintCard();
            }

            Console.ReadKey();
        }
    }
}
