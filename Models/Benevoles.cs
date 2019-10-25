using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBv2.Models
{
    public class Benevoles
    {
        public int ID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string poste { get; set; }
        public int nb_jour { get; set; }
    }
}