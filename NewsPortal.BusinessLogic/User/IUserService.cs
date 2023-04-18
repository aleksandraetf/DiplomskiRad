using NewsPortal.BusinessLogic.User.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.BusinessLogic.User
{
    public interface IUserService
    {
        UserModel GetById(int id);
        AuthenticateResponse Authenticate(AuthenticateRequest model);
    }
}
