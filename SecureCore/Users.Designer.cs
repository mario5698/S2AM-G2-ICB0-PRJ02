namespace SecureCore
{
    partial class Users
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
            this.Actualizar_Base = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb7 = new System.Windows.Forms.TextBox();
            this.txb6 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txb5 = new System.Windows.Forms.TextBox();
            this.txb8 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txb9 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txb4 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb10 = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Actualizar_Base
            // 
            this.Actualizar_Base.Location = new System.Drawing.Point(424, 244);
            this.Actualizar_Base.Name = "Actualizar_Base";
            this.Actualizar_Base.Size = new System.Drawing.Size(114, 43);
            this.Actualizar_Base.TabIndex = 20;
            this.Actualizar_Base.Text = "SAVE";
            this.Actualizar_Base.UseVisualStyleBackColor = true;
            this.Actualizar_Base.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(3, 309);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersWidth = 62;
            this.dtgUsers.RowTemplate.Height = 28;
            this.dtgUsers.Size = new System.Drawing.Size(795, 112);
            this.dtgUsers.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(266, 244);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 43);
            this.add.TabIndex = 24;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(128, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 20);
            this.lbl1.TabIndex = 81;
            this.lbl1.Text = "User_Id";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(223, 25);
            this.txb1.Name = "txb1";
            this.txb1.ReadOnly = true;
            this.txb1.Size = new System.Drawing.Size(127, 26);
            this.txb1.TabIndex = 84;
            this.txb1.Tag = "iduser";
            // 
            // txb7
            // 
            this.txb7.Location = new System.Drawing.Point(567, 62);
            this.txb7.Name = "txb7";
            this.txb7.Size = new System.Drawing.Size(127, 26);
            this.txb7.TabIndex = 147;
            this.txb7.Tag = "idusercategory";
            // 
            // txb6
            // 
            this.txb6.Location = new System.Drawing.Point(567, 26);
            this.txb6.Name = "txb6";
            this.txb6.Size = new System.Drawing.Size(127, 26);
            this.txb6.TabIndex = 148;
            this.txb6.Tag = "iduserrank";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(425, 29);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(113, 20);
            this.lbl6.TabIndex = 145;
            this.lbl6.Text = "User_Id_Rank";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(116, 173);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(78, 20);
            this.lbl5.TabIndex = 143;
            this.lbl5.Text = "Password";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(399, 68);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(139, 20);
            this.lbl7.TabIndex = 146;
            this.lbl7.Text = "User_Id_Category";
            // 
            // txb5
            // 
            this.txb5.Location = new System.Drawing.Point(223, 170);
            this.txb5.Name = "txb5";
            this.txb5.Size = new System.Drawing.Size(127, 26);
            this.txb5.TabIndex = 144;
            this.txb5.Tag = "password";
            // 
            // txb8
            // 
            this.txb8.Location = new System.Drawing.Point(567, 98);
            this.txb8.Name = "txb8";
            this.txb8.Size = new System.Drawing.Size(127, 26);
            this.txb8.TabIndex = 152;
            this.txb8.Tag = "photo";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(100, 101);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(94, 20);
            this.lbl3.TabIndex = 140;
            this.lbl3.Text = "User_Name";
            // 
            // txb9
            // 
            this.txb9.Location = new System.Drawing.Point(567, 134);
            this.txb9.Name = "txb9";
            this.txb9.Size = new System.Drawing.Size(127, 26);
            this.txb9.TabIndex = 151;
            this.txb9.Tag = "idplanet";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(146, 137);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(48, 20);
            this.lbl4.TabIndex = 139;
            this.lbl4.Text = "Login";
            // 
            // txb4
            // 
            this.txb4.Location = new System.Drawing.Point(223, 134);
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(127, 26);
            this.txb4.TabIndex = 141;
            this.txb4.Tag = "login";
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(223, 98);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(127, 26);
            this.txb3.TabIndex = 142;
            this.txb3.Tag = "username";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(461, 137);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(77, 20);
            this.lbl9.TabIndex = 149;
            this.lbl9.Text = "Planet_Id";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(104, 65);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(90, 20);
            this.lbl2.TabIndex = 137;
            this.lbl2.Text = "User_Code";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(484, 104);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(54, 20);
            this.lbl8.TabIndex = 150;
            this.lbl8.Text = "Image";
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(223, 62);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(127, 26);
            this.txb2.TabIndex = 138;
            this.txb2.Tag = "codeuser";
            // 
            // txb10
            // 
            this.txb10.Location = new System.Drawing.Point(567, 170);
            this.txb10.Name = "txb10";
            this.txb10.Size = new System.Drawing.Size(127, 26);
            this.txb10.TabIndex = 154;
            this.txb10.Tag = "idspecie";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(457, 173);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(81, 20);
            this.lbl10.TabIndex = 153;
            this.lbl10.Text = "Specie_Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl10);
            this.panel1.Controls.Add(this.txb10);
            this.panel1.Controls.Add(this.txb2);
            this.panel1.Controls.Add(this.lbl8);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl9);
            this.panel1.Controls.Add(this.txb3);
            this.panel1.Controls.Add(this.txb4);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.txb9);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.txb8);
            this.panel1.Controls.Add(this.txb5);
            this.panel1.Controls.Add(this.lbl7);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.txb6);
            this.panel1.Controls.Add(this.txb7);
            this.panel1.Controls.Add(this.txb1);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 222);
            this.panel1.TabIndex = 81;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(92, 244);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 43);
            this.cancel.TabIndex = 82;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dtgUsers);
            this.Controls.Add(this.Actualizar_Base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Actualizar_Base;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb7;
        private System.Windows.Forms.TextBox txb6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox txb5;
        private System.Windows.Forms.TextBox txb8;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txb9;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txb4;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb10;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
    }
}