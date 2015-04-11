/*Name: Fidelis Msacky
  Course: CMPS4143 - Contemporary Prog. Lang.
  Prof: C. Stringfellow 
  Program 7: Inventory Program
  Date: 11/15/2014
 
  Summary: This program utilises FIlestrem to read and 
           write to file, menus, list boxed and a MDI*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Prog7_Inventory
{
    public partial class ItemInformation : Form
    {
        public string recordData = null;
        public ItemInformation()
        {
            InitializeComponent();
            OkButton.Enabled = false;
        }

        public ItemInformation(string dataToUpdate)
        {
            // Show insert form with fields to be updated
            InitializeComponent();

            string[] newFields;

            newFields = dataToUpdate.Split('\t');

            IDBox.Text = newFields[0];
            NameBox.Text = newFields[1];
            PriceBox.Text = newFields[2];
            QuantityBox.Text = newFields[3];
        }

        private void OkButton_Click(object sender, EventArgs e)
        {            
            // Store user entry
            recordData = IDBox.Text + "\t" + NameBox.Text + "\t" +
                         String.Format("{0:f2}", PriceBox.Text) + "\t" + QuantityBox.Text;
            
            this.Close();             
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close form and set variable to null
            recordData = null;
            this.Close();
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            // Only enable ok button if all fields have data
            if ((string.IsNullOrWhiteSpace(IDBox.Text)) || (string.IsNullOrWhiteSpace(PriceBox.Text)) ||
                (string.IsNullOrWhiteSpace(NameBox.Text)) || (string.IsNullOrWhiteSpace(QuantityBox.Text)))
            {
                OkButton.Enabled = false;
            }
            else
            {
                OkButton.Enabled = true;
            }
        }
    }
}
