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
            this.swCodi1 = new Controles_Usuario.SWCodi();
            this.swTextbox1 = new BlibliotecaG2.SWTextbox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // swCodi1
            // 
            this.swCodi1.BackColor = System.Drawing.Color.Transparent;
            this.swCodi1.ClasseCS = null;
            this.swCodi1.ControlID = null;
            this.swCodi1.FormCS = null;
            this.swCodi1.Location = new System.Drawing.Point(365, 71);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.NomCOdi = null;
            this.swCodi1.NomDesc = null;
            this.swCodi1.NomId = null;
            this.swCodi1.NomTaula = null;
            this.swCodi1.Requerit = false;
            this.swCodi1.Size = new System.Drawing.Size(345, 53);
            this.swCodi1.TabIndex = 2;
            // 
            // swTextbox1
            // 
            this.swTextbox1.dada = " ";
            this.swTextbox1.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Codi;
            this.swTextbox1.Foranea = false;
            this.swTextbox1.Location = new System.Drawing.Point(327, 167);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Nom_BBDD = null;
            this.swTextbox1.obligatorio = true;
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 0;
            this.swTextbox1.TextChanged += new System.EventHandler(this.swTextbox1_TextChanged);
            this.swTextbox1.Leave += new System.EventHandler(this.swTextbox1_Leave);
            // 
            // TestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.swTextbox1);
            this.Name = "TestUserControl";
            this.Text = "TestUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlibliotecaG2.SWTextbox swTextbox1;
        private System.Windows.Forms.TextBox textBox1;
        private Controles_Usuario.SWCodi swCodi1;
    }
}