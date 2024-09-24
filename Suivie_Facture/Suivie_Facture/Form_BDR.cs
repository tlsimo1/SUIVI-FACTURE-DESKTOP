using Microsoft.Office.Interop.Excel;
using Suivie_Facture.BL;
using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Suivie_Facture
{
    public partial class Form_BDR : Form
    {
        Brd_BL bdr_bl = new Brd_BL();
        Facture_BL factureBl = new Facture_BL();
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        System.Data.DataTable dtAutoComplet = new System.Data.DataTable();
        System.Windows.Forms.TextBox Txt_NewFournissur = new System.Windows.Forms.TextBox();
        public Form_BDR()
        {
            InitializeComponent();
            dtAutoComplet = factureBl.AutoCompletTextBox();
            cmb_tva.Text = "20%";
        }
        private void Form_BDR_Load(object sender, EventArgs e)
        {
            Auto();
            dte_saisie.Value = Convert.ToDateTime(DateTime.Now.ToString("d/M/yy hh:mm:ss.fffffff"));
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            

            bool ifexistFournissur = factureBl.ChekFournisseurIfExist(txt_fr.Text);
            var Guid_val = Guid.NewGuid().ToString();
            if (ifexistFournissur==true)
            {
                
                try
                {
                    if (txt_facture.Text == "" || txt_fr.Text == "" || dte_facture.Text == "" || txt_des.Text == "")
                    {
                        MessageBox.Show("Merci de remplir tous les champs");
                    }
                    else
                    {
                        Facture facture = new Facture();
                        facture.NumFacture = txt_facture.Text;
                        facture.Fournisseur = txt_fr.Text;
                        facture.Date_Facture = Convert.ToDateTime(dte_facture.Text);
                        facture.Date_Saisie = Convert.ToDateTime(dte_saisie.Value);
                        facture.Designation = txt_des.Text;
                        facture.GuidVal = Guid_val;
                        bdr_bl.InsertFacture(facture);
                        MessageBox.Show("Facture Ajouter avec succés");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (txt_facture.Text == "" || txt_fr.Text == "" || dte_facture.Text == "" || txt_des.Text == "")
                    {
                        MessageBox.Show("Merci de remplir tous les champs");
                    }
                    else
                    {
                        Facture facture = new Facture();
                        facture.NumFacture = txt_facture.Text;
                        facture.Fournisseur = txt_fr.Text;
                        facture.Date_Facture = Convert.ToDateTime(dte_facture.Text);
                        facture.Date_Saisie = Convert.ToDateTime(dte_saisie.Value);
                        facture.Designation = txt_des.Text;
                        facture.GuidVal = Guid_val;
                        facture.New_Fournisseur = txt_fr.Text;
                        bdr_bl.InsertFacture(facture);
                        MessageBox.Show("Facture Ajouter avec succés");
                        coll.Add(txt_fr.Text);
                        txt_fr.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txt_fr.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txt_fr.AutoCompleteCustomSource = coll;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            SetTextBox();
            //dtAutoComplet = factureBl.AutoCompletTextBox();
            
        }
        void SetTextBox()
        {
            txt_des.Text = "";
            txt_facture.Text = "";
            txt_fr.Text = "";
            dte_facture.Value = DateTime.Now;
            dte_saisie.Value = DateTime.Now;
            txt_mtHT.Text = "";
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            SetTextBox();
        }
        public void Auto()
        {
            for (int i = 0; i < dtAutoComplet.Rows.Count; i++)
            {
                coll.Add(dtAutoComplet.Rows[i]["raisonsocial"].ToString());
            }
            
            txt_fr.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_fr.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_fr.AutoCompleteCustomSource = coll;
        }

        private void txt_des_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as System.Windows.Forms.TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }           
        }

        private void txt_mtHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as System.Windows.Forms.TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txt_mtHT_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_mtHT_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_mtHT.Text == "") return;
            else
            {
                float TTC = 0;
                float values = 0;
                float v = int.Parse(cmb_tva.Text.Replace("%", ""));
                values = v / 100;
                TTC = float.Parse(txt_mtHT.Text.Replace(".", ",")) + (float.Parse(txt_mtHT.Text.Replace(".", ",")) * values);
                txt_des.Text = TTC.ToString();
            }
            
        }

        private void cmb_tva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_mtHT.Text!="")
            {
                float TTC = 0;
                float values = 0;
                float v = int.Parse(cmb_tva.Text.Replace("%", ""));
                values = v / 100;
                TTC = float.Parse(txt_mtHT.Text.Replace(".", ",")) + (float.Parse(txt_mtHT.Text.Replace(".", ","))*values);
                txt_des.Text = TTC.ToString();
            }
        }

        private void txt_mtHT_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_mtHT.Text == "") txt_des.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Variable.DynamicText == 1)
            {
                
                int count = panel1.Controls.OfType<System.Windows.Forms.TextBox>().ToList().Count;
                Txt_NewFournissur.Location = new System.Drawing.Point(18, 45 * count);
                Txt_NewFournissur.Size = new System.Drawing.Size(335, 27);
                Txt_NewFournissur.Name = "txt_" + (count + 1);
                panel1.Controls.Add(Txt_NewFournissur);
                Variable.DynamicText++;
            }
        }

    }
}
