using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Manager
{
    public class LoginAndRegistrationManager
    {
        LoginAndRegistrationRepository _loginAndRegistrationRepository=new LoginAndRegistrationRepository();
        public bool Registration(Registration registration)
        {
            return _loginAndRegistrationRepository.Registration(registration);
        }

        public bool Login(Registration registration)
        {
            return _loginAndRegistrationRepository.Login(registration);
        }
    }
}
