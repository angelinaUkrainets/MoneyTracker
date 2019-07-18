using DLL.Entities;
using MoneyTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public class UserRepository : IMoneyTrackerRepository<User>
    {
        private readonly EFContext _context;
        public UserRepository(EFContext context)
        {
            _context = context;
        }
        public bool Add(User elem)
        {
            try
            {
                _context.Users.Add(elem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(t => t.ID == id);
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<User> Get()
        {
            return _context.Users.AsEnumerable();
        }

    }
}
