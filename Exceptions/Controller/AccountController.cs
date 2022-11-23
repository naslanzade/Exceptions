using Domain.Models;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Controller
{
    public  class AccountController
    {
        public void Register()
        {            
            try
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();

                Console.WriteLine("Enter email");
                string email = Console.ReadLine();

                if (!email.Contains("@")) throw new Exception("Email doesnt have @");


                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                IAccountService service = new AccountService();


                User newuser = new()
                {
                    Username = username,
                    Email = email,
                    Password = password
                };

                var result = service.Register(newuser);

                if (!result) throw new Exception("Email doesnt have @");

                Console.WriteLine("Success");
               

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        public void GetUserById()
        {


            try
            {
                IAccountService service = new AccountService();
                var result=service.GetUserById(3);
                Console.WriteLine(result.Username);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
