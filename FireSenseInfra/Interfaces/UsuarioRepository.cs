using FireSenseInfra.Context;

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
    }
}
