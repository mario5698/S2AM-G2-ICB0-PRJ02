﻿namespace Formularios
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
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            this.Actualizar_Base = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.specie_id_swtxb = new BlibliotecaG2.SWTextbox();
            this.planet_id_swtxb = new BlibliotecaG2.SWTextbox();
            this.photo_swtxb = new BlibliotecaG2.SWTextbox();
            this.user_id_category_swtxb = new BlibliotecaG2.SWTextbox();
            this.id_user_rank_swtxb = new BlibliotecaG2.SWTextbox();
            this.user_id_swtxb = new BlibliotecaG2.SWTextbox();
            this.login_swtxb = new BlibliotecaG2.SWTextbox();
            this.password_swtxb = new BlibliotecaG2.SWTextbox();
            this.swCodi1 = new Controles_Usuario.SWCodi();
            this.user_cod_swtxb = new BlibliotecaG2.SWTextbox();
            this.user_name_swtxb = new BlibliotecaG2.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgUsers.Location = new System.Drawing.Point(0, 643);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersWidth = 62;
            this.dtgUsers.RowTemplate.Height = 28;
            this.dtgUsers.Size = new System.Drawing.Size(1920, 437);
            this.dtgUsers.TabIndex = 93;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.Color.PaleGreen;
            this.cancel.Location = new System.Drawing.Point(466, 427);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 43);
            this.cancel.TabIndex = 108;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Actualizar_Base
            // 
            this.Actualizar_Base.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Actualizar_Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Actualizar_Base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.Actualizar_Base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar_Base.ForeColor = System.Drawing.Color.PaleGreen;
            this.Actualizar_Base.Location = new System.Drawing.Point(646, 427);
            this.Actualizar_Base.Name = "Actualizar_Base";
            this.Actualizar_Base.Size = new System.Drawing.Size(114, 43);
            this.Actualizar_Base.TabIndex = 106;
            this.Actualizar_Base.Text = "SAVE";
            this.Actualizar_Base.UseVisualStyleBackColor = false;
            this.Actualizar_Base.Click += new System.EventHandler(this.Actualizar_Base_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.PaleGreen;
            this.add.Location = new System.Drawing.Point(283, 427);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 43);
            this.add.TabIndex = 107;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl1.Location = new System.Drawing.Point(171, 92);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(97, 29);
            this.lbl1.TabIndex = 81;
            this.lbl1.Text = "User_Id";
            // 
            // lbl6
            // 
            this.lbl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl6.Location = new System.Drawing.Point(536, 97);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(165, 29);
            this.lbl6.TabIndex = 145;
            this.lbl6.Text = "User_Id_Rank";
            // 
            // lbl5
            // 
            this.lbl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl5.Location = new System.Drawing.Point(148, 247);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(120, 29);
            this.lbl5.TabIndex = 143;
            this.lbl5.Text = "Password";
            // 
            // lbl7
            // 
            this.lbl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl7.Location = new System.Drawing.Point(494, 135);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(207, 29);
            this.lbl7.TabIndex = 146;
            this.lbl7.Text = "User_Id_Category";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl3.Location = new System.Drawing.Point(126, 171);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(142, 29);
            this.lbl3.TabIndex = 140;
            this.lbl3.Text = "User_Name";
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl4.Location = new System.Drawing.Point(195, 209);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(73, 29);
            this.lbl4.TabIndex = 139;
            this.lbl4.Text = "Login";
            // 
            // lbl9
            // 
            this.lbl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl9.Location = new System.Drawing.Point(585, 209);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(114, 29);
            this.lbl9.TabIndex = 149;
            this.lbl9.Text = "Planet_Id";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl2.Location = new System.Drawing.Point(132, 133);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(136, 29);
            this.lbl2.TabIndex = 137;
            this.lbl2.Text = "User_Code";
            // 
            // lbl8
            // 
            this.lbl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl8.Location = new System.Drawing.Point(619, 171);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(80, 29);
            this.lbl8.TabIndex = 150;
            this.lbl8.Text = "Image";
            // 
            // lbl10
            // 
            this.lbl10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl10.Location = new System.Drawing.Point(577, 247);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(122, 29);
            this.lbl10.TabIndex = 153;
            this.lbl10.Text = "Specie_Id";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(107, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 156;
            this.label1.Text = "Specie_Code";
            // 
            // specie_id_swtxb
            // 
            this.specie_id_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.specie_id_swtxb.ControllID = "swCodi1";
            this.specie_id_swtxb.dada = null;
            this.specie_id_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Num;
            this.specie_id_swtxb.Foranea = true;
            this.specie_id_swtxb.Location = new System.Drawing.Point(742, 251);
            this.specie_id_swtxb.Name = "specie_id_swtxb";
            this.specie_id_swtxb.Nom_BBDD = "idspecie";
            this.specie_id_swtxb.obligatorio = true;
            this.specie_id_swtxb.Size = new System.Drawing.Size(127, 26);
            this.specie_id_swtxb.TabIndex = 10;
            this.specie_id_swtxb.Tag = "";
            this.specie_id_swtxb.TextChanged += new System.EventHandler(this.specie_id_swtxb_TextChanged);
            // 
            // planet_id_swtxb
            // 
            this.planet_id_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.planet_id_swtxb.ControllID = null;
            this.planet_id_swtxb.dada = null;
            this.planet_id_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Num;
            this.planet_id_swtxb.Foranea = false;
            this.planet_id_swtxb.Location = new System.Drawing.Point(742, 213);
            this.planet_id_swtxb.Name = "planet_id_swtxb";
            this.planet_id_swtxb.Nom_BBDD = "idplanet";
            this.planet_id_swtxb.obligatorio = true;
            this.planet_id_swtxb.Size = new System.Drawing.Size(127, 26);
            this.planet_id_swtxb.TabIndex = 8;
            this.planet_id_swtxb.Tag = "";
            // 
            // photo_swtxb
            // 
            this.photo_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.photo_swtxb.ControllID = null;
            this.photo_swtxb.dada = null;
            this.photo_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.photo_swtxb.Foranea = false;
            this.photo_swtxb.Location = new System.Drawing.Point(742, 175);
            this.photo_swtxb.Name = "photo_swtxb";
            this.photo_swtxb.Nom_BBDD = "photo";
            this.photo_swtxb.obligatorio = false;
            this.photo_swtxb.Size = new System.Drawing.Size(127, 26);
            this.photo_swtxb.TabIndex = 7;
            this.photo_swtxb.Tag = "";
            // 
            // user_id_category_swtxb
            // 
            this.user_id_category_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_id_category_swtxb.ControllID = null;
            this.user_id_category_swtxb.dada = null;
            this.user_id_category_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Num;
            this.user_id_category_swtxb.Foranea = true;
            this.user_id_category_swtxb.Location = new System.Drawing.Point(742, 139);
            this.user_id_category_swtxb.Name = "user_id_category_swtxb";
            this.user_id_category_swtxb.Nom_BBDD = "idusercategory";
            this.user_id_category_swtxb.obligatorio = true;
            this.user_id_category_swtxb.Size = new System.Drawing.Size(127, 26);
            this.user_id_category_swtxb.TabIndex = 6;
            this.user_id_category_swtxb.Tag = "";
            // 
            // id_user_rank_swtxb
            // 
            this.id_user_rank_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.id_user_rank_swtxb.ControllID = null;
            this.id_user_rank_swtxb.dada = null;
            this.id_user_rank_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Num;
            this.id_user_rank_swtxb.Foranea = true;
            this.id_user_rank_swtxb.Location = new System.Drawing.Point(742, 101);
            this.id_user_rank_swtxb.Name = "id_user_rank_swtxb";
            this.id_user_rank_swtxb.Nom_BBDD = "iduserrank";
            this.id_user_rank_swtxb.obligatorio = true;
            this.id_user_rank_swtxb.Size = new System.Drawing.Size(127, 26);
            this.id_user_rank_swtxb.TabIndex = 5;
            this.id_user_rank_swtxb.Tag = "";
            // 
            // user_id_swtxb
            // 
            this.user_id_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_id_swtxb.ControllID = null;
            this.user_id_swtxb.dada = null;
            this.user_id_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.user_id_swtxb.Foranea = false;
            this.user_id_swtxb.Location = new System.Drawing.Point(307, 96);
            this.user_id_swtxb.Name = "user_id_swtxb";
            this.user_id_swtxb.Nom_BBDD = "iduser";
            this.user_id_swtxb.obligatorio = false;
            this.user_id_swtxb.ReadOnly = true;
            this.user_id_swtxb.Size = new System.Drawing.Size(127, 26);
            this.user_id_swtxb.TabIndex = 161;
            this.user_id_swtxb.Tag = "";
            // 
            // login_swtxb
            // 
            this.login_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_swtxb.ControllID = null;
            this.login_swtxb.dada = null;
            this.login_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.login_swtxb.Foranea = false;
            this.login_swtxb.Location = new System.Drawing.Point(307, 210);
            this.login_swtxb.Name = "login_swtxb";
            this.login_swtxb.Nom_BBDD = "login";
            this.login_swtxb.obligatorio = false;
            this.login_swtxb.Size = new System.Drawing.Size(127, 26);
            this.login_swtxb.TabIndex = 3;
            this.login_swtxb.Tag = "";
            // 
            // password_swtxb
            // 
            this.password_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password_swtxb.ControllID = null;
            this.password_swtxb.dada = null;
            this.password_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.password_swtxb.Foranea = false;
            this.password_swtxb.Location = new System.Drawing.Point(307, 248);
            this.password_swtxb.Name = "password_swtxb";
            this.password_swtxb.Nom_BBDD = "password";
            this.password_swtxb.obligatorio = false;
            this.password_swtxb.Size = new System.Drawing.Size(127, 26);
            this.password_swtxb.TabIndex = 4;
            this.password_swtxb.Tag = "";
            // 
            // swCodi1
            // 
            this.swCodi1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodi1.BackColor = System.Drawing.Color.Transparent;
            this.swCodi1.ClasseCS = null;
            this.swCodi1.ControlID = "specie_id_swtxb";
            this.swCodi1.ForeColor = System.Drawing.Color.Black;
            this.swCodi1.FormCS = null;
            this.swCodi1.Location = new System.Drawing.Point(307, 312);
            this.swCodi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.NomCodi = "codespecie";
            this.swCodi1.NomDesc = "descspecie";
            this.swCodi1.NomId = "idspecie";
            this.swCodi1.NomTaula = "species";
            this.swCodi1.Requerit = false;
            this.swCodi1.Size = new System.Drawing.Size(562, 43);
            this.swCodi1.TabIndex = 9;
            // 
            // user_cod_swtxb
            // 
            this.user_cod_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_cod_swtxb.ControllID = null;
            this.user_cod_swtxb.dada = null;
            this.user_cod_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.user_cod_swtxb.Foranea = false;
            this.user_cod_swtxb.Location = new System.Drawing.Point(307, 133);
            this.user_cod_swtxb.Name = "user_cod_swtxb";
            this.user_cod_swtxb.Nom_BBDD = "codeuser";
            this.user_cod_swtxb.obligatorio = false;
            this.user_cod_swtxb.Size = new System.Drawing.Size(127, 26);
            this.user_cod_swtxb.TabIndex = 1;
            this.user_cod_swtxb.Tag = "";
            // 
            // user_name_swtxb
            // 
            this.user_name_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_name_swtxb.ControllID = null;
            this.user_name_swtxb.dada = null;
            this.user_name_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.user_name_swtxb.Foranea = false;
            this.user_name_swtxb.Location = new System.Drawing.Point(307, 172);
            this.user_name_swtxb.Name = "user_name_swtxb";
            this.user_name_swtxb.Nom_BBDD = "username";
            this.user_name_swtxb.obligatorio = false;
            this.user_name_swtxb.Size = new System.Drawing.Size(127, 26);
            this.user_name_swtxb.TabIndex = 2;
            this.user_name_swtxb.Tag = "";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.specie_id_swtxb);
            this.Controls.Add(this.planet_id_swtxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photo_swtxb);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.user_id_category_swtxb);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.id_user_rank_swtxb);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Actualizar_Base);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dtgUsers);
            this.Controls.Add(this.user_id_swtxb);
            this.Controls.Add(this.login_swtxb);
            this.Controls.Add(this.password_swtxb);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.user_cod_swtxb);
            this.Controls.Add(this.user_name_swtxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Actualizar_Base;
        private System.Windows.Forms.Button add;
        private Controles_Usuario.SWCodi swCodi1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl10;
        private BlibliotecaG2.SWTextbox user_cod_swtxb;
        private BlibliotecaG2.SWTextbox user_name_swtxb;
        private BlibliotecaG2.SWTextbox login_swtxb;
        private BlibliotecaG2.SWTextbox password_swtxb;
        private BlibliotecaG2.SWTextbox user_id_swtxb;
        private BlibliotecaG2.SWTextbox id_user_rank_swtxb;
        private BlibliotecaG2.SWTextbox user_id_category_swtxb;
        private BlibliotecaG2.SWTextbox photo_swtxb;
        private BlibliotecaG2.SWTextbox planet_id_swtxb;
        private BlibliotecaG2.SWTextbox specie_id_swtxb;
        private System.Windows.Forms.Label label1;
    }
}