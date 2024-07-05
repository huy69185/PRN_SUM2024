using BookManagement.DAL.Models;
using BookManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Services
{
    public class UserService
    {
        private readonly UserRepository _repo = new();

        public UserAccount AuthenticateUser(string email, string password)
        {
            return _repo.GetUserByEmailAndPassword(email, password);
        }
        //check roleID thỏa mới cho vào
        public bool IsAuthorizedRole(UserAccount user)
        {
            return user.Role == 1 || user.Role == 2;
        }
    }
}
