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
    public partial class StoreForm : Form
    {
        private StreamReader reader;
        private BinaryFormatter binReader;
        public readonly string activefile = null;

        public StoreForm()
        {
            InitializeComponent();
        }

        public StoreForm(string filename, string filepath)
        {
            InitializeComponent();
            InvListBox.Sorted = true;

            string fileData = null;

            string displayname = filename;
            activefile = filepath;
            
            NameLabel.Text = "Store: " + displayname;

            try
            {
                binReader = new BinaryFormatter();

                FileStream inputfile = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                // Record itemRecord; 
                
                // reader = new StreamReader(inputfile);


                //Read data from file
                while (inputfile.Length != inputfile.Position)
                {
                   Record itemRecord = (Record) binReader.Deserialize(inputfile);
                    
                    fileData = itemRecord.id + "\t" + itemRecord.name + "\t"
                               + String.Format("{0:f2}", itemRecord.price)
                               + "\t" + itemRecord.quantity;
                                                           
                    InvListBox.Items.Add(fileData);
                }

                InfoLabel.Text = "There is/are " + InvListBox.Items.Count.ToString() + " item(s) in this inventory";

                inputfile.Close(); //close the stream
            }
            catch (IOException)
            {
                MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public StoreForm(string filename)
        {
            InitializeComponent();
            InvListBox.Sorted = true;
            
            string currentDirectory = Directory.GetCurrentDirectory();
            string displayname = filename;

            activefile = currentDirectory + "\\Store Files" + "\\" + filename + ".inv";
            // MessageBox.Show(filename);

            var newfile = File.Create(activefile);
            NameLabel.Text = "Store: " + displayname;
            InfoLabel.Text = "There are no items in this inventory";

            newfile.Close();    
            // string header = "Header Stuff";
        }
    }
}
