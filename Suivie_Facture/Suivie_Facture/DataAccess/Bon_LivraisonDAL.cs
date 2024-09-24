using Suivie_Facture.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.DataAccess
{
    public class Bon_LivraisonDAL
    {
        public void Insert_BonLivraison(Bon_Livraison bon_Livraison)
        {
            using (SqlConnection connection = new SqlConnection(Connexion.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Bon_Livraison (Num_BL, Fournissuer, Date_BL, Date_Saisi,Bon_Entre,Article,Qte) " +
                                                    $" VALUES('{bon_Livraison.Num_BL}','{bon_Livraison.Fournissuer.Trim().Replace("'", "''")}'," +
                                                    $"'{bon_Livraison.Date_BL.ToString("dd/MM/yyyy")}'," +
                                                    $"'{Convert.ToDateTime(bon_Livraison.Date_Saisi.ToString("dd/MM/yyyy hh:mm:ss.fffffff"))}'," +
                                                    $"'{bon_Livraison.Bon_Entre}','{bon_Livraison.Article.Trim().Replace("'", "''")}',{bon_Livraison.Qte})", connection, transaction);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                        ex.Message.ToString();
                        transaction.Rollback();
                }
            }
        }
    }
}
