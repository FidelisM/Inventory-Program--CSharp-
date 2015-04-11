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
    public partial class InvParent : Form
    {
        int count = 0;

        StoreForm storeForm;
                
        ItemInformation InsertForm;
        
        // private StreamWriter writer;
        
        private BinaryFormatter binWriter;

        public InvParent()
        {
            InitializeComponent();
            
            insertToolStripMenuItem.Enabled = false;
            updateToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            // create new file and child window then display child window
            string filename = null;

            GetFileName storeNameDialog;

            storeNameDialog = new GetFileName();
            storeNameDialog.ShowDialog();

            filename = storeNameDialog.file_Name1.FilenameVal;            

            if (filename != null)
            {
                storeForm = new StoreForm(filename);
                storeForm.MdiParent = this;
                storeForm.Show();

                insertToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory() + "\\Store Files";
            string filename = null;
            string filepath = null;

            // Reading from file using open file dialogue
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = currentDirectory;

            // Show only .txt files
            openFile.Filter = "inv files (*.inv)|*.inv|All files (*.*)|*.*";

            // Show actual dialog
            openFile.ShowDialog();

            try
            {
                // Store filename 
                filepath = openFile.FileName;
                filename = Path.GetFileNameWithoutExtension(filepath);

                StoreForm storeForm = new StoreForm(filename, filepath);
                storeForm.MdiParent = this;
                storeForm.Show();

                insertToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }

            catch
            {
                return;
            }
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            InsertForm = new ItemInformation();
            InsertForm.ShowDialog();

            if (InsertForm.recordData != null)
            {
                // Add new item to active child list box
                StoreForm activeChild = (StoreForm) this.ActiveMdiChild;
                activeChild.InvListBox.Items.Add(InsertForm.recordData);
                
                // Update number of items display
                count = activeChild.InvListBox.Items.Count;
                activeChild.InfoLabel.Text = "There is/are " + count.ToString() + " item(s) in this inventory";
            }           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get active child
            StoreForm activeChild = (StoreForm) this.ActiveMdiChild;
            Record itemRecord = new Record();
            
            // Get file associated with active child
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileToUpdate = activeChild.activefile;
                        
            try
            {
                binWriter = new BinaryFormatter();

                // Save data from listbox to file with overwrite
                FileStream outfile = new FileStream(fileToUpdate, FileMode.Create, FileAccess.Write);
                // writer = new StreamWriter(outfile);

                foreach (string item in activeChild.InvListBox.Items)
                {
                    // item	"2222\tChocolate\t5.99\t25"	string
                    string[] indivItems = item.Split('\t');

                    itemRecord.id = Int32.Parse(indivItems[0]);
                    itemRecord.name = indivItems[1];
                    itemRecord.price = Double.Parse(indivItems[2]);
                    itemRecord.quantity = Int32.Parse(indivItems[3]);

                    binWriter.Serialize(outfile, itemRecord);                    
                }

                outfile.Close(); // close
                
                MessageBox.Show("Data saved to File.", "Save File", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }

            catch (IOException)
            {
                //Notify user if file does not exists
                MessageBox.Show("Error Saving Data to File.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get active child
            StoreForm activeChild = (StoreForm) this.ActiveMdiChild;

            // Check if selection was made
            if (activeChild.InvListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Remove item
                activeChild.InvListBox.Items.Remove(activeChild.InvListBox.SelectedItem);

                // Update number of items display
                count = activeChild.InvListBox.Items.Count;
                activeChild.InfoLabel.Text = "There is/are " + count.ToString() + " item(s) in this inventory";
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get active child
            StoreForm activeChild = (StoreForm)this.ActiveMdiChild;

            // Cheack if selection is made
            if (activeChild.InvListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Get text from selected entry                
                string entryToUpdate = activeChild.InvListBox.SelectedItem.ToString();

                InsertForm = new ItemInformation(entryToUpdate);
                InsertForm.ShowDialog();

                if (InsertForm.recordData != null)
                {
                    // Add new item to active child list box
                    activeChild.InvListBox.Items.Remove(activeChild.InvListBox.SelectedItem);
                    activeChild.InvListBox.Items.Add(InsertForm.recordData);

                    // Update number of items display
                    count = activeChild.InvListBox.Items.Count;
                    activeChild.InfoLabel.Text = "There is/are " + count.ToString() + " item(s) in this inventory";
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }
    }
}
