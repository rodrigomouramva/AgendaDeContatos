using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos.Core.Modelos
{
    public abstract class EntidadeBase : IEntidade
    {
        public long Id { get; set;}

        public static implicit operator bool(EntidadeBase entidade)
        {
            return entidade != null;
        }


    }
}
