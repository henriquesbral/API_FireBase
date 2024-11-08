using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FireSenseDomain.Entities
{
    public class Usuario
    {        

        [Key]
        public int CodUsuario { get; set; }

        public string? Login { get; set; }

        public string? Nome { get; set; }

        public string? Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        [ForeignKey("PerfilUsuario")]
        public int? CodPerfil { get; set; }

        private DateTime dateTime;

        public Usuario(string? login, string? nome, string? senha, DateTime dateTime, int? codPerfil)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
            this.dateTime = dateTime;
            CodPerfil = codPerfil;
        }
    }
}
