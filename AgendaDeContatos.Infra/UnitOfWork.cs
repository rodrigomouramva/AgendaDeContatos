using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos.Infra
{
    public class UnitOfWork<T> where T : DbContext
    {
        //protected  readonly T dbContext;
        public T Context { get; private set; }
        public UnitOfWork(T dbContext)
        {
            Context = dbContext;
        }

        public T Type { get; set; }

        public void Save()
        {

        }
    }
}
