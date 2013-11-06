/*
 * Name: Durwin Barcenas
 * Date: Oct 9,2013
 * version: 1.0
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AutoCenterForm : Form
    {
      

        public AutoCenterForm()
        {
            InitializeComponent();
            
        }
        /**
         * This method changes the font and label of the BasePrice, AmountDue,
         * and Amount
         * */
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initializing the dialog box 
            fontDialog1.Font = BasePriceTextBox.Font;
            fontDialog1.Font = AmountDueTextBox.Font;
            fontDialog1.Font = BasePriceLabel.Font;
            fontDialog1.Font = AmountDueLabel.Font;
            //shows the dialog of fonts
            fontDialog1.ShowDialog();

            //Assigning new Font
            BasePriceTextBox.Font = fontDialog1.Font;
            AmountDueTextBox.Font = fontDialog1.Font;
            BasePriceLabel.Font = fontDialog1.Font;
            AmountDueLabel.Font = fontDialog1.Font;
        }

        /**
         * This method will change the color of BasePriceTextBox, AmountDueTextBox,
         * BasePriceLabel, and AmountDueLabel.
         * */
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initialize the dialog box. 
            colorDialog1.Color = BasePriceTextBox.ForeColor;
            colorDialog1.Color = AmountDueTextBox.ForeColor;
            colorDialog1.Color = BasePriceLabel.ForeColor;
            colorDialog1.Color = AmountDueLabel.ForeColor;
            //shows the dialog of color
            colorDialog1.ShowDialog();

            //Assigning new Color 
            BasePriceTextBox.ForeColor = colorDialog1.Color;
            AmountDueTextBox.ForeColor = colorDialog1.Color;
            BasePriceLabel.ForeColor = colorDialog1.Color;
            AmountDueLabel.ForeColor = colorDialog1.Color;
        }// end of method colorToolStripMenuItem_Click

        //This method will close the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }// end of method exitToolStripMenuItem_Click

        //This method will show a messagebox when About menu strip is clicked 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle"); 
        }// end of method aboutToolStripMenuItem_Click

        /*
         * This method will add up the Additional Items and Exterior Finish when clicked 
         * and outputs it to the AdditionalOptionTextBox. 
         * */
        private void AdditionalOptionsTextBox_TextChanged(object sender, EventArgs e)
        {
            //declare variables
            decimal stereo = 425.76m;
            decimal interior = 987.41m;
            decimal navigation = 1741.23m;
            decimal additionalTempTotal = 0m, additionalTotal = 0m;
            

                // if statements to check if the Stereo, Leather, and Navigation is checked
                // it will add it's formula and stores it into additinalTemp 
                if (StereoSystemCheckBox.Checked && LeatherInteriorCheckBox.Checked && !ComputerNavCheckBox.Checked){
                    additionalTempTotal = stereo + interior;
                }
                else if (StereoSystemCheckBox.Checked && ComputerNavCheckBox.Checked && !LeatherInteriorCheckBox.Checked) {
                    additionalTempTotal = stereo + navigation;
                }
                else if (LeatherInteriorCheckBox.Checked && ComputerNavCheckBox.Checked && !StereoSystemCheckBox.Checked){
                    additionalTempTotal = stereo + navigation;
                }
                else if (LeatherInteriorCheckBox.Checked && ComputerNavCheckBox.Checked && StereoSystemCheckBox.Checked)
                {
                    additionalTempTotal = stereo + navigation + interior;
                }
                else if (LeatherInteriorCheckBox.Checked)
                {
                    additionalTempTotal = interior;
                }
                else if (ComputerNavCheckBox.Checked )
                {
                    additionalTempTotal = navigation;
                }
                else if (StereoSystemCheckBox.Checked)
                {
                    additionalTempTotal = stereo;
                }

                // if statements to check if PearlizedRadioButton and CustomizedRadioButton is checked 
                // then calls method PearlizedAdd and CustomizedAdd 
                //to calculate then and stores it to additionalTotal
                    if (PearlizedRadioButton.Checked)
                    {
                        additionalTotal = PearlizedAdd(additionalTempTotal);
                    }

                    else if (CustomizedRadioButton.Checked)
                    {
                        additionalTotal = CustomizedAdd(additionalTempTotal);
                    }
                    else
                    {
                        additionalTotal = additionalTempTotal;
                    }
                  // Outputs the additionalTotal into string to AdditionalOptionsTextBox
                    AdditionalOptionsTextBox.Text = additionalTotal.ToString();

        }// end of method AdditionalOptionsTextBox_TextChanged

        /**
         * This method will add the additionalTempTotal and the pearlized 
         * and set it to the total variable
         * @returns total 
         * */
        private decimal PearlizedAdd(decimal additionalTempTotal)
        {
            decimal pearlized = 345.72m, total;
            return total = additionalTempTotal + pearlized;
        }// end of method PearlizedAdd
        /**
         * This method will add the additionalTempTotal and the customized 
         * and set it to the total variable
         * @returns total
         * */
        private decimal CustomizedAdd(decimal additionalTempTotal)
        {
            decimal customized = 599.99m, total;
            return total = additionalTempTotal + customized; 
        }// end of method CustomizedAdd

       // This method will calulate the addtionalOptions, basePrice, subTotal, total,
       // salesTax, tradeInAllowance and Amount due.
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // declaring variables and initializing the BasePriceTextbox, AdditionalOptionsTextBox,
            // and TradeAllowanceTextBox to decimal variables
            try
            {
                decimal basePrice = decimal.Parse(BasePriceTextBox.Text);
                decimal additionalOptions = decimal.Parse(AdditionalOptionsTextBox.Text);
                decimal tradeInAllowance = decimal.Parse(TradeAllowanceTextBox.Text);
                decimal subTotal, salesTax = 0.13m, salesTaxTotal, total, amountDue;

                // this will calculate the sub total
                subTotal = additionalOptions + basePrice;
                // outputs the subtotal
                SubTotalTextBox.Text = subTotal.ToString();
                // calculates the salestaxTotal
                salesTaxTotal = subTotal * salesTax;
                //outputs the SalesTax
                SalesTaxTextBox.Text = salesTaxTotal.ToString("C");
                //calculates the total
                total = salesTaxTotal + subTotal;
                //outputs the Total
                TotalTextBox.Text = total.ToString("C");
                //calculates the amount due
                amountDue = total - tradeInAllowance;
                //outputs the amount due 
                AmountDueTextBox.Text = amountDue.ToString("C");
            }
            catch {
                MessageBox.Show("Either Base Price, Trade-in Allowance and Additional Option has an empty value.", "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }// end of method CalculateButton_Click

        // this method will clear all the texboxes when clicked 
        // calls another method ClearTextBoxes
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls); 
        }// end of method ClearButton_Click

        // this method will clear all the textboxes content
        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox textBox = ctrl as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }// end if
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }// end else
            }// end foreach
        }// end of method ClearTextBoxes

        // This method will only allow numeric characters and a single decimal to 
        // input inside the textbox 
        private void BasePriceTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                 && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }// end if

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }// end if
        }// end of method BasePriceTextBox_TextChanged
      
    }   // end of class
}   
