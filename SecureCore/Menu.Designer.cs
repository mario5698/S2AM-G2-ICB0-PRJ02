namespace SecureCore
{
    partial class Menu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_HideLeftPanel = new System.Windows.Forms.Button();
            this.btn_Opt1 = new System.Windows.Forms.Button();
            this.btn_Opt2 = new System.Windows.Forms.Button();
            this.btn_Opt3 = new System.Windows.Forms.Button();
            this.btn_Opt4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 411);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_HideLeftPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btn_Opt4);
            this.panel4.Controls.Add(this.btn_Opt3);
            this.panel4.Controls.Add(this.btn_Opt2);
            this.panel4.Controls.Add(this.btn_Opt1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 382);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // btn_HideLeftPanel
            // 
            this.btn_HideLeftPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HideLeftPanel.Location = new System.Drawing.Point(3, 3);
            this.btn_HideLeftPanel.Name = "btn_HideLeftPanel";
            this.btn_HideLeftPanel.Size = new System.Drawing.Size(40, 23);
            this.btn_HideLeftPanel.TabIndex = 0;
            this.btn_HideLeftPanel.Text = "≡";
            this.btn_HideLeftPanel.UseVisualStyleBackColor = true;
            this.btn_HideLeftPanel.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_Opt1
            // 
            this.btn_Opt1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Opt1.Location = new System.Drawing.Point(0, 0);
            this.btn_Opt1.Name = "btn_Opt1";
            this.btn_Opt1.Size = new System.Drawing.Size(200, 79);
            this.btn_Opt1.TabIndex = 0;
            this.btn_Opt1.Text = "button1";
            this.btn_Opt1.UseVisualStyleBackColor = true;
            this.btn_Opt1.Click += new System.EventHandler(this.btn_Opt1_Click);
            // 
            // btn_Opt2
            // 
            this.btn_Opt2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Opt2.Location = new System.Drawing.Point(0, 79);
            this.btn_Opt2.Name = "btn_Opt2";
            this.btn_Opt2.Size = new System.Drawing.Size(200, 79);
            this.btn_Opt2.TabIndex = 1;
            this.btn_Opt2.Text = "button2";
            this.btn_Opt2.UseVisualStyleBackColor = true;
            this.btn_Opt2.Click += new System.EventHandler(this.btn_Opt2_Click);
            // 
            // btn_Opt3
            // 
            this.btn_Opt3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Opt3.Location = new System.Drawing.Point(0, 158);
            this.btn_Opt3.Name = "btn_Opt3";
            this.btn_Opt3.Size = new System.Drawing.Size(200, 79);
            this.btn_Opt3.TabIndex = 2;
            this.btn_Opt3.Text = "button3";
            this.btn_Opt3.UseVisualStyleBackColor = true;
            this.btn_Opt3.Click += new System.EventHandler(this.btn_Opt3_Click);
            // 
            // btn_Opt4
            // 
            this.btn_Opt4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Opt4.Location = new System.Drawing.Point(0, 237);
            this.btn_Opt4.Name = "btn_Opt4";
            this.btn_Opt4.Size = new System.Drawing.Size(200, 79);
            this.btn_Opt4.TabIndex = 3;
            this.btn_Opt4.Text = "button4";
            this.btn_Opt4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 382);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_HideLeftPanel;
        private System.Windows.Forms.Button btn_Opt4;
        private System.Windows.Forms.Button btn_Opt3;
        private System.Windows.Forms.Button btn_Opt2;
        private System.Windows.Forms.Button btn_Opt1;
    }
}