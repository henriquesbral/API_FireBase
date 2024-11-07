using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSense.Domain.FireSenseContext.Entities
{
    public class Estado
    {
        [Key]
        public int CodEstado { get; set; }

        public string NomeEstado { get; set; }

        public string SiglaEstado { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
