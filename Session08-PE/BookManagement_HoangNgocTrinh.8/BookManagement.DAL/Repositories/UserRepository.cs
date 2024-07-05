using BookManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Repositories
{
    public class UserRepository
    {
        private readonly BookManagementDbContext _context;

        public UserRepository()
        {
            _context = new BookManagementDbContext();
        }

        public UserAccount GetUserByEmailAndPassword(string email, string password)
        {
            return _context.UserAccounts.FirstOrDefault(user => user.Email == email && user.Password == password);
        }
    }
}
