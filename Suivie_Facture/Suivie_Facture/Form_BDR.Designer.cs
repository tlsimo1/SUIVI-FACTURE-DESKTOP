namespace Suivie_Facture
{
    partial class Form_BDR
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
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.dte_saisie = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dte_facture = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_facture = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_tva = new System.Windows.Forms.ComboBox();
            this.txt_mtHT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_des
            // 
            this.txt_des.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_des.Location = new System.Drawing.Point(432, 216);
            this.txt_des.Name = "txt_des";
            this.txt_des.ReadOnly = true;
            this.txt_des.Size = new System.Drawing.Size(249, 27);
            this.txt_des.TabIndex = 13;
            this.txt_des.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_des_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total TTC";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_annuler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_annuler.Location = new System.Drawing.Point(399, 303);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(150, 38);
            this.btn_annuler.TabIndex = 11;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // dte_saisie
            // 
            this.dte_saisie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dte_saisie.Enabled = false;
            this.dte_saisie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_saisie.Location = new System.Drawing.Point(432, 148);
            this.dte_saisie.Name = "dte_saisie";
            this.dte_saisie.Size = new System.Drawing.Size(249, 27);
            this.dte_saisie.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Saisie";
            // 
            // dte_facture
            // 
            this.dte_facture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dte_facture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_facture.Location = new System.Drawing.Point(432, 80);
            this.dte_facture.Name = "dte_facture";
            this.dte_facture.Size = new System.Drawing.Size(249, 27);
            this.dte_facture.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Facture";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fournisseur";
            // 
            // txt_facture
            // 
            this.txt_facture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_facture.Location = new System.Drawing.Point(29, 80);
            this.txt_facture.Name = "txt_facture";
            this.txt_facture.Size = new System.Drawing.Size(373, 27);
            this.txt_facture.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro Facture";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUREAU D\'ORDRE";
            // 
            // txt_fr
            // 
            this.txt_fr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fr.Location = new System.Drawing.Point(29, 148);
            this.txt_fr.Name = "txt_fr";
            this.txt_fr.Size = new System.Drawing.Size(373, 27);
            this.txt_fr.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmb_tva);
            this.panel1.Controls.Add(this.txt_mtHT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_annuler);
            this.panel1.Controls.Add(this.btn_valider);
            this.panel1.Controls.Add(this.txt_fr);
            this.panel1.Controls.Add(this.txt_des);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dte_saisie);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_facture);
            this.panel1.Controls.Add(this.dte_facture);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(108, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 374);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "TVA";
            // 
            // cmb_tva
            // 
            this.cmb_tva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tva.FormattingEnabled = true;
            this.cmb_tva.Items.AddRange(new object[] {
            "20%",
            "0%",
            "07%",
            "10%"});
            this.cmb_tva.Location = new System.Drawing.Point(281, 216);
            this.cmb_tva.Name = "cmb_tva";
            this.cmb_tva.Size = new System.Drawing.Size(121, 27);
            this.cmb_tva.TabIndex = 17;
            this.cmb_tva.SelectedIndexChanged += new System.EventHandler(this.cmb_tva_SelectedIndexChanged);
            // 
            // txt_mtHT
            // 
            this.txt_mtHT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mtHT.Location = new System.Drawing.Point(29, 216);
            this.txt_mtHT.Name = "txt_mtHT";
            this.txt_mtHT.Size = new System.Drawing.Size(212, 27);
            this.txt_mtHT.TabIndex = 16;
            this.txt_mtHT.Enter += new System.EventHandler(this.txt_mtHT_Enter);
            this.txt_mtHT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mtHT_KeyDown);
            this.txt_mtHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mtHT_KeyPress);
            this.txt_mtHT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mtHT_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Montant HT";
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_valider.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_valider.Image = global::Suivie_Facture.Properties.Resources.icons8_save_close_32px_1;
            this.btn_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_valider.Location = new System.Drawing.Point(173, 303);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(153, 38);
            this.btn_valider.TabIndex = 10;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // Form_BDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 412);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_BDR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BDR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_BDR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_facture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dte_saisie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dte_facture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_mtHT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_tva;
    }
}