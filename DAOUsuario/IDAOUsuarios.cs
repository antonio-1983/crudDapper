using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOUsuario
{
    
        public interface IDAOUsuarios
        {
            public List<Usuario> ObtenerUsuarios();
            public Usuario ObtenerUsuario(int id);
            public void InsertarUsuario(string nombre, int edad);
            public void EliminarUsuario(int id);

        }
    
}
