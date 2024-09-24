using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Suivie_Facture.BL;
using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Suivie_Facture
{
    public partial class Imprimer : Form
    {
        Facture_BL facture_BL = new Facture_BL();
        Factures FacturesDS = new Factures();
        Imprimer_Factures imp = new Imprimer_Factures();
        DataTable datatable = new DataTable();
        DataTable datatable_Fournisseur = new DataTable();

        public Imprimer()
        {
            string name2 = Environment.UserName;
            string file = ($"C:\\Users\\{name2}\\Downloads\\Factures.pdf");
            try
            {
                InitializeComponent();
                datatable_Fournisseur= facture_BL.GetFactureImp2(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
                Imprimer_Factures imprimer_Factures = new Imprimer_Factures();
                imprimer_Factures.Database.Tables["GetAllFactureByDate"].SetDataSource(datatable_Fournisseur);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = imprimer_Factures;
                imprimer_Factures.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, file);
                System.Diagnostics.Process.Start(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
