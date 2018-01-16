namespace PartkeeprScannr
{
    partial class PartShow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.ConfigMenu = new System.Windows.Forms.MenuItem();
            this.Exitmenu = new System.Windows.Forms.MenuItem();
            this.readBarcode = new System.Windows.Forms.Button();
            this.partID = new System.Windows.Forms.TextBox();
            this.partName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.part_description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.partsAdd = new System.Windows.Forms.Button();
            this.partsRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.partStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.ConfigMenu);
            this.mainMenu1.MenuItems.Add(this.Exitmenu);
            // 
            // ConfigMenu
            // 
            this.ConfigMenu.Text = "Config";
            this.ConfigMenu.Click += new System.EventHandler(this.ConfigMenu_Click);
            // 
            // Exitmenu
            // 
            this.Exitmenu.Text = "Exit";
            this.Exitmenu.Click += new System.EventHandler(this.Exitmenu_Click);
            // 
            // readBarcode
            // 
            this.readBarcode.Location = new System.Drawing.Point(160, 7);
            this.readBarcode.Name = "readBarcode";
            this.readBarcode.Size = new System.Drawing.Size(72, 21);
            this.readBarcode.TabIndex = 0;
            this.readBarcode.Text = "Senden";
            this.readBarcode.Click += new System.EventHandler(this.readBarcode_Click);
            // 
            // partID
            // 
            this.partID.Location = new System.Drawing.Point(30, 7);
            this.partID.Name = "partID";
            this.partID.Size = new System.Drawing.Size(124, 21);
            this.partID.TabIndex = 1;
            this.partID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.partID_KeyUp);
            // 
            // partName
            // 
            this.partName.Location = new System.Drawing.Point(57, 46);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(154, 51);
            this.partName.Text = "No part selected";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.Text = "Description:";
            // 
            // part_description
            // 
            this.part_description.Location = new System.Drawing.Point(8, 113);
            this.part_description.Name = "part_description";
            this.part_description.Size = new System.Drawing.Size(224, 35);
            this.part_description.Text = "No part selected\r\n";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.Text = "Avg Price:";
            // 
            // avgPrice
            // 
            this.avgPrice.Location = new System.Drawing.Point(95, 188);
            this.avgPrice.Name = "avgPrice";
            this.avgPrice.Size = new System.Drawing.Size(100, 21);
            this.avgPrice.TabIndex = 7;
            this.avgPrice.Text = "0.00";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(202, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.Text = "EUR";
            // 
            // partsAdd
            // 
            this.partsAdd.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.partsAdd.Location = new System.Drawing.Point(102, 214);
            this.partsAdd.Name = "partsAdd";
            this.partsAdd.Size = new System.Drawing.Size(63, 49);
            this.partsAdd.TabIndex = 9;
            this.partsAdd.Text = "+";
            this.partsAdd.Click += new System.EventHandler(this.partsAdd_Click);
            // 
            // partsRemove
            // 
            this.partsRemove.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.partsRemove.Location = new System.Drawing.Point(170, 214);
            this.partsRemove.Name = "partsRemove";
            this.partsRemove.Size = new System.Drawing.Size(63, 49);
            this.partsRemove.TabIndex = 10;
            this.partsRemove.Text = "-";
            this.partsRemove.Click += new System.EventHandler(this.partsRemove_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.Text = "Stock:";
            // 
            // partStock
            // 
            this.partStock.Location = new System.Drawing.Point(12, 233);
            this.partStock.Name = "partStock";
            this.partStock.Size = new System.Drawing.Size(69, 20);
            this.partStock.Text = "0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "Location:";
            // 
            // partLocation
            // 
            this.partLocation.Location = new System.Drawing.Point(68, 151);
            this.partLocation.Name = "partLocation";
            this.partLocation.Size = new System.Drawing.Size(169, 35);
            this.partLocation.Text = "No part selected";
            // 
            // PartShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.partLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.partStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.partsRemove);
            this.Controls.Add(this.partsAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avgPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.part_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.readBarcode);
            this.Menu = this.mainMenu1;
            this.Name = "PartShow";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.PartShow_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.PartShow_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readBarcode;
        private System.Windows.Forms.TextBox partID;
        private System.Windows.Forms.Label partName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label part_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avgPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button partsAdd;
        private System.Windows.Forms.Button partsRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label partStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuItem ConfigMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label partLocation;
        private System.Windows.Forms.MenuItem Exitmenu;
    }
}

