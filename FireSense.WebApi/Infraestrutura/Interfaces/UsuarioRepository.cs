using FireSense.WebApi.Model.Entities;
using FireSense.WebApi.Model.Interfaces;
using FireSenseInfra.Context;
using System.Linq;

namespace FireSenseInfra.Interfaces
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly FireSenseContext _context = new FireSenseContext();

        public void Add(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> Get()
        {
            return _context.Usuario.ToList();
        }

        //public Usuario? Get(string login, string senha)
        //{
        //    return _context.Usuario.Find(login);
        //}

        //public List<Usuario> Get(string login)
        //{
        //    return _context.Usuario.ToList();
        //}
    }
}
