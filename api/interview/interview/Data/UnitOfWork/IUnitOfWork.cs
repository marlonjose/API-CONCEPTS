using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interview.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
