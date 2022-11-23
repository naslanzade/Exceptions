using Domain.Models;
using Service.Exceptions;
using Service.Helpers.Constant;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Controller
{
    public  class LoginController
    {
        public void Login()
        {
			try
			{
                Console.WriteLine("Enter email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                ILoginService loginService=new LoginService();

                Login newlogin = new()
                {

                    Email = email,
                    Password = password
                };

                var result=loginService.Login(newlogin);

                if (!result) throw new IncorrectLogin(ExceptionsMessages.IncorrectLogin);

                Console.WriteLine("Enter is success");

            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
