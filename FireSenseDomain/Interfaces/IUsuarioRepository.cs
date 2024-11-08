using FireSenseDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireSenseDomain.Interfaces
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);

        List<Usuario> Get();
    }
}
