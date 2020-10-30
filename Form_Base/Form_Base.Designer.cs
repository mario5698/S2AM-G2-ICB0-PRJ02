namespace Form_Base
{
    partial class Form_Base
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
            this.lbl6 = new System.Windows.Forms.Label();
            this.txb6 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Actualizar_Base = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(420, 19);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(113, 20);
            this.lbl6.TabIndex = 30;
            this.lbl6.Text = "User_Id_Rank";
            // 
            // txb6
            // 
            this.txb6.Location = new System.Drawing.Point(562, 16);
            this.txb6.Name = "txb6";
            this.txb6.Size = new System.Drawing.Size(127, 26);
            this.txb6.TabIndex = 33;
            this.txb6.Tag = "descspecie";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(99, 58);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(90, 20);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "User_Code";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(123, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 20);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "User_Id";
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(218, 52);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(127, 26);
            this.txb2.TabIndex = 22;
            this.txb2.Tag = "codespecie";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(218, 16);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(127, 26);
            this.txb1.TabIndex = 23;
            this.txb1.Tag = "idspecie";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.txb6);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.txb2);
            this.panel1.Controls.Add(this.txb1);
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 203);
            this.panel1.TabIndex = 26;
            // 
            // Actualizar_Base
            // 
            this.Actualizar_Base.Location = new System.Drawing.Point(324, 247);
            this.Actualizar_Base.Name = "Actualizar_Base";
            this.Actualizar_Base.Size = new System.Drawing.Size(114, 43);
            this.Actualizar_Base.TabIndex = 25;
            this.Actualizar_Base.Text = "SAVE";
            this.Actualizar_Base.UseVisualStyleBackColor = true;
            this.Actualizar_Base.Click += new System.EventHandler(this.Actualizar_Base_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(3, 312);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.RowHeadersWidth = 62;
            this.dtgUsers.RowTemplate.Height = 28;
            this.dtgUsers.Size = new System.Drawing.Size(795, 112);
            this.dtgUsers.TabIndex = 24;
            // 
            // Form_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Actualizar_Base);
            this.Controls.Add(this.dtgUsers);
            this.Name = "Form_Base";
            this.Text = "Form_Base";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txb6;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Actualizar_Base;
        private System.Windows.Forms.DataGridView dtgUsers;
    }
}