using Loan_API_PCB_GD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loan_API_PCB_GD.LoginService
{
    public class UserService : IUserService
    {
        public LoginModel GetUserDetails()
        {
            return new LoginModel { UserName = "Jay", Password = "123456" };
        }

        public bool IsValidUserInformation(LoginModel model)
        {
            if (model.UserName.Equals("Jay") && model.Password.Equals("123456")) return true;
            else return false;
        }
    }
}
