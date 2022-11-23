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
    public class Factorial : IFactorial
    {
        public int CalculationOfFactorial()
        {
            int num;
            int factorial = 1;
            num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                throw new IncorrectNumber(ExceptionsMessages.IncorrectNumber);
            }
            for (int i = num; i >= 2; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }



       
    }
}
