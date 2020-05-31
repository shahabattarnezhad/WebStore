using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DataLayer.Entities.User;

namespace WebStore.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
    }
}
