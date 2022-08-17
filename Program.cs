using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistratiponProblem;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateFirstName("Anisha");
            validateUser.validateLastName("Das");
            validateUser.validateEmailId("anishadas880@gmail.com");
            validateUser.validateMobileNumber("9178009885");
            validateUser.validatePassword("Anisha@987");
            Console.ReadKey();
        }
    }
}