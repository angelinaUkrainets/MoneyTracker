using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public class CategoryRepository : IMoneyTrackerRepository<Category>
    {
        private readonly EFContext _context;
        public CategoryRepository(EFContext context)
        {
            _context = context;
        }
        public bool Add(Category elem)
        {
            try
            {
                _context.Categories.Add(elem);
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
                var category = _context.Categories.FirstOrDefault(t => t.ID == id);
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Category> Get()
        {
            return _context.Categories.AsEnumerable();
        }
    }
}
