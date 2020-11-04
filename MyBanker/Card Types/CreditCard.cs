using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class CreditCard : Card
    {
        Random rnd = new Random();

        private int expirationMonth;

        public int ExpirationMonth
        {
            get { return expirationMonth; }
            set { expirationMonth = value; }
        }

        private int expirationYear;

        public int ExpirationYear
        {
            get { return expirationYear; }
            set { expirationYear = value; }
        }

        private int minMonthValid;

        public int MinMonthValid
        {
            get { return minMonthValid; }
            set { minMonthValid = value; }
        }

        private int maxMonthValid;

        public int MaxMonthValid
        {
            get { return maxMonthValid; }
            set { maxMonthValid = value; }
        }

        public DateTime AddMonthsToCurrentDate(int Months)
        {
            DateTime now = DateTime.Now;
            now.AddMonths(Months);
            return (now.AddMonths(Months));
        }
        public void SetExpiration()
        {
            int MonthsBeforeExpire = (rnd.Next(MinMonthValid, maxMonthValid));
            this.expirationMonth = (AddMonthsToCurrentDate(MonthsBeforeExpire).Month);
            this.expirationYear = (AddMonthsToCurrentDate(MonthsBeforeExpire).Year);
        }
        public void PrettyPrintCard()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(this.NameOnCard);
            Console.WriteLine(this.CardNo);
            Console.WriteLine(this.expirationMonth + "/" +this.expirationYear);
            Console.WriteLine("------------------------");
        }
    }
}
