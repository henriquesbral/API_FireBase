using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FireSense.WebApi.Model.Entities
{
    public class Usuario
    {

        [Key]
        public int CodUsuario { get; init; }

        public string? Login { get; private set; }

        public string? Nome { get; private set; }

        public string? Senha { get; private set; }

        public DateTime DataCadastro { get; private set; }

        [ForeignKey("PerfilUsuario")]
        public int? CodPerfil { get; set; }

        public Usuario(string? login, string? nome, string? senha, int? codPerfil)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
            DataCadastro = DateTime.Now;
            CodPerfil = codPerfil;
        }
    }
}
