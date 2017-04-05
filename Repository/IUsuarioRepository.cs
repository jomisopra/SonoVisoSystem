using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Repository
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetUsuarios(string criterio);

        Usuario GetUsuario(Int32 id);

        void AddUsuario(Usuario usuario);

        void UpdateUsuario(Usuario usuario);

        void DeleteUsuario(Int32 usuario);
    }
}
