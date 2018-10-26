using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace joe_and_bob_banking
{
    class LedgerUser
    {
        public String Name;
        public Double Cash; //if this were a real application using money, this is not correct.

        public void AddCash(Double cash)
        {
            /* Using add cash because you can add negative money. */

            //Check to see if we can add the cash.
            Double currentValue = cash + Cash;
            if(currentValue < 0)
            {
                MessageBox.Show("Invalid amount!"); //added for ease of use.
            }
            else
            {
                Cash = currentValue;
            }
        }

    }
}
