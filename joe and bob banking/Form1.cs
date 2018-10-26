using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joe_and_bob_banking
{
    public partial class Form1 : Form
    {
        LedgerUser joe = new LedgerUser { Name = "Joe", Cash = 32.5 };
        LedgerUser bob = new LedgerUser { Name = "Bob", Cash = 300.40 };
        public Form1()
        {
            InitializeComponent();
            updateForm();
        }

        private Double CheckInputAndAdd()
        {
            //This will both ensure that the input is valid and return the proper double
            //for calculation. If the input is invalid, it returns 0 which will make no change.
            try
            {
                Convert.ToDouble(valueToTransfer.Text);
            }
            catch (Exception)
            {
                return 0.0;
            }
            return Convert.ToDouble(valueToTransfer.Text);
        }

       
        private void firstUserTransferButton_Click(object sender, EventArgs e)
        {
            Double amountToTransfer = CheckInputAndAdd();
            bob.AddCash(-amountToTransfer);
            joe.AddCash(amountToTransfer);
            updateForm();
        }

        private void secondUserTransferButton_Click(object sender, EventArgs e)
        {
            Double amountToTransfer = CheckInputAndAdd();
            joe.AddCash(-amountToTransfer);
            bob.AddCash(amountToTransfer); //One line, but it's not as clear.
            updateForm();
        }
        private void updateForm()
        {
            String transferButtonText = "Transfer to ";
            firstNameLabel.Text = joe.Name;
            secondNameLabel.Text = bob.Name;
            firstNameDollars.Text = joe.Cash.ToString();
            secondNameDollars.Text = bob.Cash.ToString();
            firstUserTransferButton.Text = transferButtonText + joe.Name;
            secondUserTransferButton.Text = transferButtonText + bob.Name;
        }
    }
}
