using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suivie_Facture.Class
{
    public class Bon_Livraison
    {
        public int ID_Bl { get; set; }
        public string Num_BL { get; set; }
        public string Fournissuer { get; set; }
        public DateTime Date_BL { get; set; }
        public DateTime Date_Saisi { get; set; }
        public string Bon_Entre { get; set; }
        public string Article { get; set; }
        public string Qte { get; set; }
    }
}
