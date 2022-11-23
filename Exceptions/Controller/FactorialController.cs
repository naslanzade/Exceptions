using Service.Services.Interface;
using Service.Services;

namespace Exceptions.Controller
{
    public  class FactorialController
    {
      
        public void FactorialCalculation()
        {
            try
            {
                IFactorial factorial = new Factorial();                
                var result = factorial.CalculationOfFactorial();
                Console.WriteLine(result);                                     
               
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
