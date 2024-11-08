using FireSense.WebApi.Model.Entities;

namespace FireSenseDomain.Interfaces
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);
        List<Usuario> Get();
    }
}
