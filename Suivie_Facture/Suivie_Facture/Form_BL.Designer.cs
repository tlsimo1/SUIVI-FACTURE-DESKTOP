namespace Suivie_Facture
{
    partial class Form_BL
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
            this.txt_qte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_article = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txt_fr = new System.Windows.Forms.TextBox();
            this.txt_bnentree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dte_saisi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numbl = new System.Windows.Forms.TextBox();
            this.dte_bl = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txt_qte);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_article);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_annuler);
            this.panel1.Controls.Add(this.btn_valider);
            this.panel1.Controls.Add(this.txt_fr);
            this.panel1.Controls.Add(this.txt_bnentree);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dte_saisi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_numbl);
            this.panel1.Controls.Add(this.dte_bl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(273, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 401);
            this.panel1.TabIndex = 16;
            // 
            // txt_qte
            // 
            this.txt_qte.Location = new System.Drawing.Point(42, 283);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(249, 27);
            this.txt_qte.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qté";
            // 
            // txt_article
            // 
            this.txt_article.Location = new System.Drawing.Point(395, 212);
            this.txt_article.Name = "txt_article";
            this.txt_article.Size = new System.Drawing.Size(249, 27);
            this.txt_article.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contrôle Flux";
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_annuler.Location = new System.Drawing.Point(386, 339);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(150, 38);
            this.btn_annuler.TabIndex = 11;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_valider.Image = global::Suivie_Facture.Properties.Resources.icons8_save_close_32px_1;
            this.btn_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_valider.Location = new System.Drawing.Point(160, 339);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(153, 38);
            this.btn_valider.TabIndex = 10;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_fr
            // 
            this.txt_fr.Location = new System.Drawing.Point(395, 62);
            this.txt_fr.Name = "txt_fr";
            this.txt_fr.Size = new System.Drawing.Size(249, 27);
            this.txt_fr.TabIndex = 14;
            // 
            // txt_bnentree
            // 
            this.txt_bnentree.Location = new System.Drawing.Point(42, 212);
            this.txt_bnentree.Name = "txt_bnentree";
            this.txt_bnentree.Size = new System.Drawing.Size(249, 27);
            this.txt_bnentree.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro BL";
            // 
            // dte_saisi
            // 
            this.dte_saisi.Enabled = false;
            this.dte_saisi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_saisi.Location = new System.Drawing.Point(395, 138);
            this.dte_saisi.Name = "dte_saisi";
            this.dte_saisi.Size = new System.Drawing.Size(249, 27);
            this.dte_saisi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Saisie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fournisseur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "N° Bon d\'entrèe";
            // 
            // txt_numbl
            // 
            this.txt_numbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_numbl.Location = new System.Drawing.Point(42, 62);
            this.txt_numbl.Name = "txt_numbl";
            this.txt_numbl.Size = new System.Drawing.Size(249, 27);
            this.txt_numbl.TabIndex = 2;
            // 
            // dte_bl
            // 
            this.dte_bl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_bl.Location = new System.Drawing.Point(42, 138);
            this.dte_bl.Name = "dte_bl";
            this.dte_bl.Size = new System.Drawing.Size(249, 27);
            this.dte_bl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date ";
            // 
            // Form_BL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 508);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_BL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_fr;
        private System.Windows.Forms.TextBox txt_bnentree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dte_saisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numbl;
        private System.Windows.Forms.DateTimePicker dte_bl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_qte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_article;
        private System.Windows.Forms.Label label7;
    }
}