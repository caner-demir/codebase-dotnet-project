using Codebase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
    }
}
