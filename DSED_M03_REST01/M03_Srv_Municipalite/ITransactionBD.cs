using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srvm
{
    public interface ITransactionBD
    {
        void Commit();
        void Rollback();
        void BeginTransaction();
    }
}
