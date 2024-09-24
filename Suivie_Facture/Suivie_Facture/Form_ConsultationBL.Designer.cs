namespace Suivie_Facture
{
    partial class Form_ConsultationBL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConsultationBL));
            this.dg_consultationBL = new Suivie_Facture.Class.ProgressDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_imp = new System.Windows.Forms.Button();
            this.txt_fournisseur = new System.Windows.Forms.TextBox();
            this.lbl_fournisseur = new System.Windows.Forms.Label();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_recherch = new System.Windows.Forms.Button();
            this.dt_recherch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_recherch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consultationBL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_consultationBL
            // 
            this.dg_consultationBL.AllowUserToAddRows = false;
            this.dg_consultationBL.AllowUserToDeleteRows = false;
            this.dg_consultationBL.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_consultationBL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_consultationBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_consultationBL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dg_consultationBL.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_consultationBL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_consultationBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_consultationBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_consultationBL.GridColor = System.Drawing.Color.LightGreen;
            this.dg_consultationBL.Location = new System.Drawing.Point(0, 46);
            this.dg_consultationBL.Margin = new System.Windows.Forms.Padding(0);
            this.dg_consultationBL.Name = "dg_consultationBL";
            this.dg_consultationBL.ReadOnly = true;
            this.dg_consultationBL.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_consultationBL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_consultationBL.Size = new System.Drawing.Size(1100, 404);
            this.dg_consultationBL.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btn_imp);
            this.groupBox1.Controls.Add(this.txt_fournisseur);
            this.groupBox1.Controls.Add(this.lbl_fournisseur);
            this.groupBox1.Controls.Add(this.btn_exp);
            this.groupBox1.Controls.Add(this.btn_recherch);
            this.groupBox1.Controls.Add(this.dt_recherch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_recherch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1100, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche Bon Livraison";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(385, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 13);
            this.progressBar1.TabIndex = 4;
            // 
            // btn_imp
            // 
            this.btn_imp.Image = ((System.Drawing.Image)(resources.GetObject("btn_imp.Image")));
            this.btn_imp.Location = new System.Drawing.Point(564, 42);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(61, 30);
            this.btn_imp.TabIndex = 7;
            this.btn_imp.UseVisualStyleBackColor = true;
            // 
            // txt_fournisseur
            // 
            this.txt_fournisseur.Location = new System.Drawing.Point(149, 41);
            this.txt_fournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fournisseur.Name = "txt_fournisseur";
            this.txt_fournisseur.Size = new System.Drawing.Size(159, 22);
            this.txt_fournisseur.TabIndex = 6;
            // 
            // lbl_fournisseur
            // 
            this.lbl_fournisseur.AutoSize = true;
            this.lbl_fournisseur.Location = new System.Drawing.Point(4, 45);
            this.lbl_fournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fournisseur.Name = "lbl_fournisseur";
            this.lbl_fournisseur.Size = new System.Drawing.Size(72, 14);
            this.lbl_fournisseur.TabIndex = 5;
            this.lbl_fournisseur.Text = "Fournisseur";
            // 
            // btn_exp
            // 
            this.btn_exp.Image = global::Suivie_Facture.Properties.Resources.excel24_0;
            this.btn_exp.Location = new System.Drawing.Point(598, 13);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(27, 27);
            this.btn_exp.TabIndex = 4;
            this.btn_exp.UseVisualStyleBackColor = true;
            // 
            // btn_recherch
            // 
            this.btn_recherch.Image = global::Suivie_Facture.Properties.Resources.icons8_google_web_search_32px;
            this.btn_recherch.Location = new System.Drawing.Point(565, 13);
            this.btn_recherch.Name = "btn_recherch";
            this.btn_recherch.Size = new System.Drawing.Size(27, 27);
            this.btn_recherch.TabIndex = 2;
            this.btn_recherch.UseVisualStyleBackColor = true;
            // 
            // dt_recherch
            // 
            this.dt_recherch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_recherch.Location = new System.Drawing.Point(385, 15);
            this.dt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.dt_recherch.Name = "dt_recherch";
            this.dt_recherch.Size = new System.Drawing.Size(171, 22);
            this.dt_recherch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Par Date :";
            // 
            // txt_recherch
            // 
            this.txt_recherch.Location = new System.Drawing.Point(149, 15);
            this.txt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_recherch.Name = "txt_recherch";
            this.txt_recherch.Size = new System.Drawing.Size(159, 22);
            this.txt_recherch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Par Numero BL:";
            // 
            // Form_ConsultationBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_consultationBL);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ConsultationBL";
            this.Text = "Form_ConsultationBL";
            ((System.ComponentModel.ISupportInitialize)(this.dg_consultationBL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Class.ProgressDataGridView dg_consultationBL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_imp;
        private System.Windows.Forms.TextBox txt_fournisseur;
        private System.Windows.Forms.Label lbl_fournisseur;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_recherch;
        private System.Windows.Forms.DateTimePicker dt_recherch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_recherch;
        private System.Windows.Forms.Label label1;
    }
}