using Suivie_Facture.BL;
using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture
{
    public partial class Form_BL : Form
    {
        
        Bon_LivraisonBL Bon_LivraisonBL = new Bon_LivraisonBL();
        public Form_BL()
        {
            InitializeComponent();
            dte_saisi.Value = Convert.ToDateTime(DateTime.Now.ToString("d/M/yy hh:mm:ss.fffffff"));
            Variable.DynamicText = 1;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            Bon_Livraison bon_Livraison = new Bon_Livraison();
            try
            {
                if (txt_numbl.Text == "" || txt_qte.Text == "" || dte_bl.Text == "" || txt_fr.Text == ""
                     || txt_article.Text == "" || txt_bnentree.Text == "")
                {
                    MessageBox.Show("Merci de remplir tous les champs");
                }
                else
                {

                    bon_Livraison.Num_BL = txt_numbl.Text;
                    bon_Livraison.Fournissuer = txt_fr.Text;
                    bon_Livraison.Date_BL = Convert.ToDateTime(dte_bl.Text);
                    bon_Livraison.Date_Saisi= Convert.ToDateTime(dte_saisi.Value);
                    bon_Livraison.Bon_Entre = txt_bnentree.Text;
                    bon_Livraison.Article = txt_article.Text;
                    bon_Livraison.Qte = txt_qte.Text;
                    Bon_LivraisonBL.InsertBonLivraison(bon_Livraison);
                    MessageBox.Show("Bon Livraison Ajouter avec succés");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SetTextBox();
        }
        void SetTextBox()
        {
            txt_numbl.Text = "";
            txt_fr.Text = "";
            txt_bnentree.Text = "";
            dte_bl.Value = DateTime.Now;
            dte_saisi.Value = DateTime.Now;
            txt_article.Text = "";
            txt_qte.Text = "";
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            SetTextBox();
        }
    }
}
