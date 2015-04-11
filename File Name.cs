using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7_Inventory
{ 

    public partial class File_Name : UserControl
    {
        private string storename;
        
        public File_Name()
        {
            InitializeComponent();
            
            CreateButton.Enabled = false;            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            // Get and stire user input
            storename = FilenameBox.Text;

            // close form from control
            ((Form)this.TopLevelControl).Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // close and set storename to null
            storename = null;
            
            // close form from control
            ((Form)this.TopLevelControl).Close();
        }

        private void FilenameBox_TextChanged(object sender, EventArgs e)
        {
            // Filename validity check 
            if (string.IsNullOrWhiteSpace(FilenameBox.Text))
            {
                CreateButton.Enabled = false;
            }
            else
            {
                CreateButton.Enabled = true;
            }
        }

        public string FilenameVal
        {
            get 
            {
                return storename;
            }
            set 
            {
                storename = value; 
            }
        }
    }
}
