﻿namespace Suivie_Facture
{
    partial class Form_ASSDAF
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
            this.dg_cmp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_recherch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_recherch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cmp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_cmp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_cmp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_cmp.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_cmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_cmp.GridColor = System.Drawing.Color.LightGreen;
            this.dg_cmp.Location = new System.Drawing.Point(0, 46);
            this.dg_cmp.Margin = new System.Windows.Forms.Padding(0);
            this.dg_cmp.Name = "dg_cmp";
            this.dg_cmp.ReadOnly = true;
            this.dg_cmp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_cmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_cmp.Size = new System.Drawing.Size(1100, 404);
            this.dg_cmp.TabIndex = 2;
            this.dg_cmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_assdaf_CellContentClick);
            this.dg_cmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_cmp_CellDoubleClick);
            this.dg_cmp.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_assdaf_CellMouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_recherch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_recherch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1100, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche Facture";
            // 
            // dt_recherch
            // 
            this.dt_recherch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_recherch.Location = new System.Drawing.Point(385, 15);
            this.dt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.dt_recherch.Name = "dt_recherch";
            this.dt_recherch.Size = new System.Drawing.Size(171, 20);
            this.dt_recherch.TabIndex = 3;
            this.dt_recherch.ValueChanged += new System.EventHandler(this.dt_recherch_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Par Date :";
            // 
            // txt_recherch
            // 
            this.txt_recherch.Location = new System.Drawing.Point(149, 15);
            this.txt_recherch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_recherch.Name = "txt_recherch";
            this.txt_recherch.Size = new System.Drawing.Size(159, 20);
            this.txt_recherch.TabIndex = 1;
            this.txt_recherch.TextChanged += new System.EventHandler(this.txt_recherch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Par Numero de Facture :";
            // 
            // Form_ASSDAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_cmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ASSDAF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form_ASSDAF";
            this.Load += new System.EventHandler(this.Form_ASSDAF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cmp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_cmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_recherch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_recherch;
        private System.Windows.Forms.Label label1;
    }
}