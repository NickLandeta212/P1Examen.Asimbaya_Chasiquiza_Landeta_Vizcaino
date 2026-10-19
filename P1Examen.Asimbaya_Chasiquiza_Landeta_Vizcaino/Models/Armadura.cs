using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ExamenP1.Asimbaya_Chasiquiza_Landeta_Vizcaino.Models
{
    public class Armadura
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombreArmadura { get; set; }
        public string tipoArmadura { get; set; }
        public int resistencia { get; set; }
        public int caballeroId { get; set; }
        public virtual Caballero Caballeros { get; set; }  

    }
}