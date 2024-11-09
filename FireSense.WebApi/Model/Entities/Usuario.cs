using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FireSense.WebApi.Model.Entities
{
    public class Usuario
    {
        #region Propries
        [Key]
        public int CodUsuario { get; set; }

        public string? Login { get; set; }

        public string? Nome { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        [ForeignKey("PerfilUsuario")]
        public int CodPerfil { get; set; }
        #endregion

        #region Constructor
        public Usuario(string login, string nome, string senha, int codPerfil)
        {
            Login = login;
            Nome = nome;
            Senha = senha;
            DataCadastro = DateTime.Now;
            CodPerfil = codPerfil;
        }
        #endregion
    }
}
