namespace Controles_Usuario
{
    partial class SWCodi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_SWCodi = new System.Windows.Forms.TextBox();
            this.TXT_SWDesc = new System.Windows.Forms.TextBox();
            this.SW_CodiText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXT_SWCodi
            // 
            this.TXT_SWCodi.Dock = System.Windows.Forms.DockStyle.Left;
            this.TXT_SWCodi.Font = new System.Drawing.Font("Arial", 10F);
            this.TXT_SWCodi.Location = new System.Drawing.Point(0, 0);
            this.TXT_SWCodi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_SWCodi.Name = "TXT_SWCodi";
            this.TXT_SWCodi.Size = new System.Drawing.Size(103, 30);
            this.TXT_SWCodi.TabIndex = 0;
            this.TXT_SWCodi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_SWCodi.TextChanged += new System.EventHandler(this.TXT_SWCodi_TextChanged);
            this.TXT_SWCodi.Leave += new System.EventHandler(this.TXT_SWCodi_Leave);
            // 
            // TXT_SWDesc
            // 
            this.TXT_SWDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.TXT_SWDesc.Enabled = false;
            this.TXT_SWDesc.Font = new System.Drawing.Font("Arial", 10F);
            this.TXT_SWDesc.HideSelection = false;
            this.TXT_SWDesc.Location = new System.Drawing.Point(176, 0);
            this.TXT_SWDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_SWDesc.Name = "TXT_SWDesc";
            this.TXT_SWDesc.Size = new System.Drawing.Size(342, 30);
            this.TXT_SWDesc.TabIndex = 1;
            this.TXT_SWDesc.TextChanged += new System.EventHandler(this.TXT_SWDesc_TextChanged);
            // 
            // SW_CodiText
            // 
            this.SW_CodiText.AllowDrop = true;
            this.SW_CodiText.Cursor = System.Windows.Forms.Cursors.No;
            this.SW_CodiText.Enabled = false;
            this.SW_CodiText.Font = new System.Drawing.Font("Arial", 10F);
            this.SW_CodiText.ForeColor = System.Drawing.Color.Red;
            this.SW_CodiText.Location = new System.Drawing.Point(189, 45);
            this.SW_CodiText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SW_CodiText.Name = "SW_CodiText";
            this.SW_CodiText.Size = new System.Drawing.Size(262, 30);
            this.SW_CodiText.TabIndex = 2;
            this.SW_CodiText.Text = "* Requerit";
            this.SW_CodiText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SW_CodiText.Visible = false;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SW_CodiText);
            this.Controls.Add(this.TXT_SWDesc);
            this.Controls.Add(this.TXT_SWCodi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(518, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_SWCodi;
        private System.Windows.Forms.TextBox TXT_SWDesc;
        private System.Windows.Forms.TextBox SW_CodiText;
    }
}
