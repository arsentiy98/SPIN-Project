using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purse_mine{
    /// <summary>
    /// class credit card can add some money to the balance
    /// </summary>
    public class CreditCard
    {
        /// <summary>
        /// 
        /// </summary>
        Money money;
        int Number;


        /// <summary>
        /// we can delete it. never used
        /// </summary>
        /// <param name="num"></param>
        void SetNumber(int num) { Number = num; }
        int GetNumber() { return Number; }


        /// <summary>
        /// is not used. we can delete it
        /// </summary>
        /// <param name="amount">is not used we can delete it</param>
        public void Pay(int amount)
        {
            double current = money.GetCash();
            if (current < amount)
            {
                MessageBox.Show("Not enough money.");
            }
            else
            {
                money.SetCash(current - amount);
            }
        }

        /*!
        \brief calculates the balance
         in 'credit card form' it calculates the credit for the user.
         after pressing 'yes' credit is added to the user's balance
        */
        public string CalculateTheCredit(string requiredSum) {
            double integer = Int32.Parse(requiredSum);
            integer += (integer * 4)/100;
            string integer2 = integer.ToString();
            return integer2;
        }

    }
}
