﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suivie_Facture.Class
{
    public class Facture
    {
        public string NumFacture;
        public string Fournisseur;
        public DateTime Date_Facture;
        public DateTime Date_Saisie;
        public string Designation { get; set; }
        public string GuidVal { get; set; }
        public string New_Fournisseur { get; set; }
    }
}
