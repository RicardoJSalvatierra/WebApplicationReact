using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationReact.Models
{
    public class tblCarProp
    {
        [Key]
        public int IdCar { get; set; }
        [Column(TypeName="nvarchar(8)")]
        public string Patente { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Marca { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Modelo { get; set; }
        public int Puertas { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Titular { get; set; }
    }
}
