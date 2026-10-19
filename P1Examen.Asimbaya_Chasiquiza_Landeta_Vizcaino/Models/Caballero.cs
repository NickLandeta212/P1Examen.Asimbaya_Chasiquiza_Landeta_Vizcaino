using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenP1.Asimbaya_Chasiquiza_Landeta_Vizcaino.Models
{
    public class Caballero
    {
        [Key]
        public int caballeroId { get; set; }
        [Required]
        public string caballeroName { get; set; }
        public string constelacion { get; set; }
        [Range(00, 10)]
        public int nivelPoder { get; set; }

        public string elemento { get; set; }

        public virtual ICollection<Armadura> Armaduras { get; set; }

    }
}