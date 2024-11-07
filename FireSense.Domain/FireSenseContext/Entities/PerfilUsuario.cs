using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSense.Domain.FireSenseContext.Entities
{
    public class PerfilUsuario
    {
        [Key]
        public int CodPerfilUsuario { get; set; }

        public string? NomePerfil { get; set; }
    }
}
