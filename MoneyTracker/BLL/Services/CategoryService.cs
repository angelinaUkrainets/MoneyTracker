using BLL.Interfaces;
using BLL.Models;
using DLL.Entities;
using DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly EFContext _context = new EFContext();
        private readonly IMoneyTrackerRepository<Category> repository;
        public CategoryService()
        {
            repository = new CategoryRepository(_context);
        }
        public int Add(CategoryAddModel category)
        {

        }
    }
}
