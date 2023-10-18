using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOUsuario
{
    public class NinjectDAOs : NinjectModule
    {
        public override void Load()
        {
            Bind<IDAOUsuarios>().To<DAOUsuarios>();
        }
    }
}
