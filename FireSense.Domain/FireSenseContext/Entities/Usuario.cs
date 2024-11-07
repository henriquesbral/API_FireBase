using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSense.Domain.FireSenseContext.Entities
{
    public class Usuario
    {
        [Key]
        public int CodUsuario { get; set; }

        public string Login { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        [ForeignKey("PerfilUsuario")]
        public int? CodPerfil { get; set; }
    }
}
