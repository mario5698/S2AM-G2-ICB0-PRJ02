namespace SecureCore
{
    partial class Welcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.Logged_User_Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ptb_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // ptb_Logo
            // 
            this.ptb_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Logo.Image = global::SecureCore.Properties.Resources.logo_black;
            this.ptb_Logo.Location = new System.Drawing.Point(0, 0);
            this.ptb_Logo.Name = "ptb_Logo";
            this.ptb_Logo.Size = new System.Drawing.Size(450, 450);
            this.ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Logo.TabIndex = 0;
            this.ptb_Logo.TabStop = false;
            // 
            // Logged_User_Name
            // 
            this.Logged_User_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logged_User_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.Logged_User_Name.ForeColor = System.Drawing.Color.Red;
            this.Logged_User_Name.Location = new System.Drawing.Point(0, 0);
            this.Logged_User_Name.Name = "Logged_User_Name";
            this.Logged_User_Name.Size = new System.Drawing.Size(350, 450);
            this.Logged_User_Name.TabIndex = 1;
            this.Logged_User_Name.Text = "User_Name";
            this.Logged_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logged_User_Name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Logged_User_Name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(450, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 450);
            this.panel2.TabIndex = 2;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Logged_User_Name;
        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.Panel panel2;
    }
}