namespace PartkeeprScannr
{
    partial class Config
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
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.serverURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userUsername = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuSave);
            // 
            // menuSave
            // 
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // serverURL
            // 
            this.serverURL.Location = new System.Drawing.Point(21, 41);
            this.serverURL.Name = "serverURL";
            this.serverURL.Size = new System.Drawing.Size(190, 21);
            this.serverURL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Server:";
            // 
            // userUsername
            // 
            this.userUsername.Location = new System.Drawing.Point(21, 108);
            this.userUsername.Name = "userUsername";
            this.userUsername.Size = new System.Drawing.Size(190, 21);
            this.userUsername.TabIndex = 2;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(21, 158);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(190, 21);
            this.userPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Password:";
            // 
            // btnShortcut
            // 
            this.btnShortcut.Location = new System.Drawing.Point(21, 209);
            this.btnShortcut.Name = "btnShortcut";
            this.btnShortcut.Size = new System.Drawing.Size(190, 20);
            this.btnShortcut.TabIndex = 5;
            this.btnShortcut.Text = "Add Shortcut";
            this.btnShortcut.Click += new System.EventHandler(this.btnShortcut_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnShortcut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverURL);
            this.Menu = this.mainMenu1;
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Config_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox serverURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userUsername;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShortcut;
    }
}