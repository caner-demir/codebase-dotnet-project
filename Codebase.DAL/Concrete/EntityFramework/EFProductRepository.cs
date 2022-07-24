using Codebase.DAL.Abstract;
using Codebase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.DAL.Concrete.EntityFramework
{
    public class EFProductRepository : EFRepository<Product>, IProductRepository
    {
    }
}
