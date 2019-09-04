using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public class OperationRepository : IMoneyTrackerRepository<Operation>
    {
        private readonly EFContext _context;
        public OperationRepository(EFContext context)
        {
            _context = context;
        }
        public bool Add(Operation elem)
        {
            try
            {
                _context.Operations.Add(elem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var operation = _context.Operations.FirstOrDefault(t => t.Id == id);
                _context.Operations.Remove(operation);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Operation> Get()
        {
            return _context.Operations.AsEnumerable();
        }
    }
}
