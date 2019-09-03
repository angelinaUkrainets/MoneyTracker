using BLL.Interfaces;
using BLL.Models;
using DLL.Entities;
using DLL.Repository;
using MoneyTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly EFContext _context = new EFContext();
        private readonly IMoneyTrackerRepository<User> repository;
        public UserService()
        {
            repository = new UserRepository(_context);
        }
        public int Login(UserLoginModel user)
        {
            int res = repository.Get().FirstOrDefault(
                u => u.Login == user.Login &&
                u.Password == user.Password)?.ID ?? -1;
            return res;
        }
        public int Register(UserRegistrationModel user)
        {
            try
            {
                int result = -1;
                User newUser;
                newUser = new User() { Login = user.Login, Password = user.Password, Name = user.Name, Surname = user.Surname, Email = user.Email, CardBalance = user.CardBalance, CashBalance = user.CashBalance };
                repository.Add(newUser);
                result = 1;
                _context.Categories.Add(new Category()
                {
                    Name = "Clothing",
                    Summ = 0,
                    UserId = newUser.ID
                });
                _context.Categories.Add(new Category()
                {
                    Name = "Dining",
                    Summ = 0,
                    UserId = newUser.ID
                });
                _context.Categories.Add(new Category()
                {
                    Name = "Education",
                    Summ = 0,
                    UserId = newUser.ID
                });
                _context.Categories.Add(new Category()
                {
                    Name = "Freetime",
                    Summ = 0,
                    UserId = newUser.ID
                });
                _context.Categories.Add(new Category()
                {
                    Name = "Health",
                    Summ = 0,
                    UserId = newUser.ID
                });
                _context.Categories.Add(new Category()
                {
                    Name = "Home",
                    Summ = 0,
                    UserId = newUser.ID
                });
                _context.Categories.Add(new Category()
                {
                    Name = "Transport",
                    Summ = 0,
                    UserId = newUser.ID
                });
                _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

           
        }
    }
}
