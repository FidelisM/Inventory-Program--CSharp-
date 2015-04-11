namespace Prog7_Inventory
{
    partial class ItemInformation
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
            this.ItemInfo = new System.Windows.Forms.GroupBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ItemInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemInfo
            // 
            this.ItemInfo.Controls.Add(this.QuantityBox);
            this.ItemInfo.Controls.Add(this.PriceBox);
            this.ItemInfo.Controls.Add(this.NameBox);
            this.ItemInfo.Controls.Add(this.IDBox);
            this.ItemInfo.Controls.Add(this.label4);
            this.ItemInfo.Controls.Add(this.label3);
            this.ItemInfo.Controls.Add(this.label2);
            this.ItemInfo.Controls.Add(this.label1);
            this.ItemInfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemInfo.Location = new System.Drawing.Point(12, 12);
            this.ItemInfo.Name = "ItemInfo";
            this.ItemInfo.Size = new System.Drawing.Size(261, 171);
            this.ItemInfo.TabIndex = 0;
            this.ItemInfo.TabStop = false;
            this.ItemInfo.Text = "Item Information";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(99, 136);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(155, 22);
            this.QuantityBox.TabIndex = 7;
            this.QuantityBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            this.QuantityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(99, 101);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(155, 22);
            this.PriceBox.TabIndex = 6;
            this.PriceBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            this.PriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(99, 66);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(155, 22);
            this.NameBox.TabIndex = 5;
            this.NameBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(99, 30);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(155, 22);
            this.IDBox.TabIndex = 4;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            this.IDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID:";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.OkButton.Location = new System.Drawing.Point(21, 189);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.CancelButton.Location = new System.Drawing.Point(191, 189);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ItemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 221);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ItemInfo);
            this.Name = "ItemInformation";
            this.Text = "Item Information";
            this.ItemInfo.ResumeLayout(false);
            this.ItemInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}