using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corgs
{
    class Gambling
    {
        public Gambling(decimal g1, decimal g2, decimal g3)
        {
            gold1 = g1;
            gold2 = g2;
            gold3 = g3;
        }

        private int GetWinner()
        {
            Random rnd = new Random();
            int winner = rnd.Next(1, 4);
            GoldTotal = Gold1/2 + Gold2/2 + Gold3/2;
            switch (winner)
            {
                case 1:
                    Gold1 = GoldTotal + Gold1 / 2;
                    Gold2 = Gold2 / 2;
                    Gold3 = Gold3 / 2;
                    return 1;
                case 2:
                    Gold1 = Gold1/2;
                    Gold2 = GoldTotal + Gold2 / 2;
                    Gold3 = Gold3 / 2;
                    return 2;
                case 3:
                    Gold1 = Gold1/2;
                    Gold2 = Gold2 / 2;
                    Gold3 = GoldTotal + Gold3 / 2;
                    return 3;
                default:
                    return 0;
            }
        }

        public int GamblePizza()
        {
            return GetWinner();
        }


        private decimal gold1;

        public decimal Gold1
        {
            get { return gold1; }
            set { gold1 = value; }
        }
        private decimal gold2;

        public decimal Gold2
        {
            get { return gold2; }
            set { gold2 = value; }
        }
        private decimal gold3;

        public decimal Gold3
        {
            get { return gold3; }
            set { gold3 = value; }
        }
        private decimal goldTotal;

        public decimal GoldTotal
        {
            get { return goldTotal; }
            set { goldTotal = value; }
        }

    }
}
