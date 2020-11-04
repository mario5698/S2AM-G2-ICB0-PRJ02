namespace SecureCore
{
    partial class TestUserControl
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.swCodi1 = new Controles_Usuario.SWCodi();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // swCodi1
            // 
            this.swCodi1.BackColor = System.Drawing.Color.Transparent;
            this.swCodi1.ClasseCS = null;
            this.swCodi1.ControlID = null;
            this.swCodi1.FormCS = null;
            this.swCodi1.Location = new System.Drawing.Point(274, 204);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.NomCodi = "";
            this.swCodi1.NomDesc = "";
            this.swCodi1.NomId = null;
            this.swCodi1.NomTaula = "test";
            this.swCodi1.Requerit = false;
            this.swCodi1.Size = new System.Drawing.Size(345, 53);
            this.swCodi1.TabIndex = 2;
            this.swCodi1.Load += new System.EventHandler(this.swCodi1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // TestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.swCodi1);
            this.Name = "TestUserControl";
            this.Text = "TestUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controles_Usuario.SWCodi swCodi1;
        private System.Windows.Forms.TextBox textBox1;
        //private Controles_Usuario.SWCodi swCodi1;
    }
}