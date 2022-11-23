using Domain.Models;
using Service.Exceptions;
using Service.Helpers.Constant;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        public bool Login(Login login)
        {
            if (!login.Email.Contains("@"))
            {
                if (!login.Password.Contains(@"[\d]"))
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
