using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOUsuario;
using Ninject;
using Org.BouncyCastle.Bcpg;

namespace EjercicioDapperCRUD
{
    public class UsuariosManager
    {
        public IDAOUsuarios DAOUsuarios { get; private set; }
        Ninject.IKernel kernel = new StandardKernel();
        

        public List<Usuario> usuarios = new List<Usuario>();
        public List<String> usuariosNombres = new List<String>();
        public UsuariosManager(IDAOUsuarios daoUsuarios)
        {
            this.DAOUsuarios = daoUsuarios;
        }

        public string ObtenerListadoDeUsuarios() 
        {
            usuarios= DAOUsuarios.ObtenerUsuarios();
            IEnumerable<Usuario> usuariosOrdenados = usuarios.OrderBy(user=>user.Edad);
            foreach (var usuario in usuariosOrdenados)
            {
                usuariosNombres.Add(usuario.Nombre);
            }
            var val = String.Join(",", usuariosNombres);
            return val;
        }
    }
}
