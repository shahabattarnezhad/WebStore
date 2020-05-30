using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
    }
}
