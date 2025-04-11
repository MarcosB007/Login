using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Interfaces
{
    public interface ILoginView
    {
        bool Validar(string user, string password);
    }
}
