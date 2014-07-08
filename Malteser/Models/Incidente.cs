using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Malteser.Models
{
    public class Incidente
    {
        [Key]
        public long ID { get; set; }
        public string FechaInc { get; set; }
        public string NroInc { get; set; }
        public int NroInterno { get; set; }
        public string NroAfiliado { get; set; }
        public string Paciente { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Sintomas { get; set; }
        public string Grado { get; set; }
        public string Cierre { get; set; }
        public string Final { get; set; }

    }
}