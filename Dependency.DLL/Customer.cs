using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.DLL
{
    public class Customer : ICustomer
    {
        public string GetCustomer(int id)
        {
            return "Rahman Mahmoodi";
        }
    }
}
