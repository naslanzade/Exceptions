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
    public class AccountService : IAccountService
    {
        public User GetUserById(int? id)
        {
            if (id is null) throw new BadRequestException(ExceptionsMessages.BadRequest);
           
            var users = GetAllUsers();

            var result = users.Find(m => m.Id == id);

            if (result==null)
            {
                throw new NotFounException(ExceptionsMessages.NotFound);
            }

            return result;               
                       
        }


        private List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            users.Add(new User { Id = 1, Username = "Test1", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 1, Username = "Test1", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 2, Username = "Test2", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 3, Username = "Test3", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 4, Username = "Test4", Email = "test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 5, Username = "Test5", Email = "test@gmail.com", Password = "12345" });

            return users;

        }



        public bool Register(User user)
        {
            if (!user.Email.Contains("@"))
            {
                return false;
            }

            return true;
        }
    }
}
