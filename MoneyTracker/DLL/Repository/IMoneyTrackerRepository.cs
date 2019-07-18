using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public interface IMoneyTrackerRepository<T>
    {
        IEnumerable<T> Get();
        bool Add(T elem);
        bool Delete(int id);
    }
}
