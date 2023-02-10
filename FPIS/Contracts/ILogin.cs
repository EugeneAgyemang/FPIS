using FPIS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPIS.Contracts
{
    public interface ILogin
    {
        LoginAuth AuthenticateUser(string employeeID, string password);
    }
}
