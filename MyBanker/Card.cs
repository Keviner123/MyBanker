using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Card
    {
        Random rnd = new Random();

        private string cardNo;

        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private string nameOnCard;

        public string NameOnCard
        {
            get { return nameOnCard; }
            set { nameOnCard = value; }
        }

        private List<int> prefixes;

        public List<int> Prefixes
        {
            get { return prefixes; }
            set { prefixes = value; }
        }

        private int minCardNoLength;

        public int MinCardNoLength
        {
            get { return minCardNoLength; }
            set { minCardNoLength = value; }
        }



        public int GetRandomPrefix()
        {
            return(Prefixes[rnd.Next(0, Prefixes.Count)]);
        }


        public string GenerateCardNo()
        {
            //Selects a random prefix
            int CardPrefix = GetRandomPrefix();

            //Subtract the amout of characters that was added by the prefix
            int CardNoLength = MinCardNoLength - CardPrefix.ToString().Length;

            string[] CardNumbers = new string[CardNoLength];

            for (int i = 0; i < CardNoLength; i++)
            {
                CardNumbers[i] = rnd.Next(1, 9).ToString();
            }

            return(CardPrefix + string.Join("", CardNumbers));
        }
    }
}
