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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.swTextbox1 = new BlibliotecaG2.SWTextbox();
            this.swCodi1 = new Controles_Usuario.SWCodi();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // swTextbox1
            // 
            this.swTextbox1._dada = null;
            this.swTextbox1.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.swTextbox1.Foranea = false;
            this.swTextbox1.Location = new System.Drawing.Point(93, 196);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Nom_BBDD = null;
            this.swTextbox1.obligatorio = false;
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 2;
            // 
            // swCodi1
            // 
            this.swCodi1.BackColor = System.Drawing.Color.Transparent;
            this.swCodi1.Location = new System.Drawing.Point(109, 46);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Requerit = true;
            this.swCodi1.Size = new System.Drawing.Size(345, 67);
            this.swCodi1.TabIndex = 0;
            this.swCodi1.Load += new System.EventHandler(this.swCodi1_Load);
            // 
            // TestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.swCodi1);
            this.Name = "TestUserControl";
            this.Text = "TestUserControl";
            this.Leave += new System.EventHandler(this.TestUserControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Usuario.SWCodi swCodi1;
        private System.Windows.Forms.TextBox textBox1;
        private BlibliotecaG2.SWTextbox swTextbox1;
    }
}