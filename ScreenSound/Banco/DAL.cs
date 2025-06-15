using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal abstract class DAL<T>
    {
        public abstract IEnumerable<T> Listar();
    }
}
