namespace Prog7_Inventory
{
    partial class GetFileName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.file_Name1 = new Prog7_Inventory.File_Name();
            this.SuspendLayout();
            // 
            // file_Name1
            // 
            this.file_Name1.Location = new System.Drawing.Point(3, 12);
            this.file_Name1.Name = "file_Name1";
            this.file_Name1.Size = new System.Drawing.Size(269, 108);
            this.file_Name1.TabIndex = 0;
            // 
            // GetFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 123);
            this.Controls.Add(this.file_Name1);
            this.Name = "GetFileName";
            this.Text = "Get File Name";
            this.ResumeLayout(false);

        }

        #endregion

        public File_Name file_Name1;

    }
}