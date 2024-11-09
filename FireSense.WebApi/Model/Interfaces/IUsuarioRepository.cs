using FireSense.WebApi.Model.Entities;

namespace FireSense.WebApi.Model.Interfaces
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);
        List<Usuario> Get();
    }
}
