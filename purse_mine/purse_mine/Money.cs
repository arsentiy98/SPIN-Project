using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purse_mine
{
    public class Money
    {
        /*!
        class can 
        1) show the current balance 
        2) add some money to the balance 
        3) remove some money from the balance
        **/

        public double cash;
        /// <summary>
        /// contains current balance
        /// </summary>
        /// <param name="a"></param>
        public void SetCash(double a)
        {
            ///add some money to the balance
            cash += a;
        }
        public double GetCash()
        {
            ///show the current balance 
            return cash;
        }
        public double Pay(double a)
        {
            ///       remove some money from the balance
            if (cash <a)
            {
                return 0;
            }
            else
            {
              return  cash = cash - a;                  
            }
        }
    }
}
