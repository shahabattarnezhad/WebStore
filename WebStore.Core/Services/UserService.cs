using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebStore.Core.Services.Interfaces;
using WebStore.DataLayer.Context;

namespace WebStore.Core.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }
        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.UserEmail == email);
        }
    }
}
