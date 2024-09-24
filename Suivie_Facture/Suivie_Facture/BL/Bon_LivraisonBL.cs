using Suivie_Facture.Class;
using Suivie_Facture.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.BL
{
    public class Bon_LivraisonBL
    {
        public Bon_LivraisonDAL Bon_LivraisonDAL;

        public void InsertBonLivraison(Bon_Livraison bon_Livraison)
        {
            Bon_LivraisonDAL = new Bon_LivraisonDAL();
            Bon_LivraisonDAL.Insert_BonLivraison(bon_Livraison);
        }
    }
}
