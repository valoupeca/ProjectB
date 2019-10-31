using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace ProjectBv2.Models
{
    public class Benevoles
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string responsable { get; set; }
        public Binary jour { get; set; }
        public string téléphoine { get; set; }
        public string permis { get; set; }
        public DateTime Datenaissance { get; set; }
        public string mail { get; set; }
        
    }
}