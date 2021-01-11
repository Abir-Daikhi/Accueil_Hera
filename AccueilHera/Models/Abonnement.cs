using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccueilHera.Models
{
    public class Abonnement
    {
        [Key]

        public int Id_Abonnement { get; set; }
        public string Nom_Abonnement { get; set; }
        public string Description_Abonnement { get; set; }
        public string Prix_Abonnement { get; set; }
        public short Statut_Abonnement { get; set; }
    }
}
