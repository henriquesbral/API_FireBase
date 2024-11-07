using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSense.Domain.FireSenseContext.Entities
{
    public class Cidade
    {
        [Key]
        public int CodCidade { get; set; }

        public string? NomeCidade { get; set; }

        [ForeignKey("Estado")]
        public int CodEstado { get; set; }

        public int CodIBGE { get; set; }

        public DateTime? DataCadastro { get; set; }
    }
}
