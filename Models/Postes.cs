using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectBv2.Models
{
    public class Postes
    {
        [Key]
        public int Id_postes { get; set; }
        public string adresse { get; set; }
        public float kilometrage { get; set; }
    }
}