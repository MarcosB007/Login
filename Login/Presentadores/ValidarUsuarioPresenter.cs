using Login.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Presentadores
{
    public class ValidarUsuarioPresenter: IValidarUsuario
    {
        public bool Validar(string user, string password)
        {
            return true;
        }
    }
}
