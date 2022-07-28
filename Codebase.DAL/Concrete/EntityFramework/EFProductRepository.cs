using Codebase.DAL.Abstract;
using Codebase.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Codebase.Entities.Concrete;

namespace Codebase.DAL.Concrete.EntityFramework
{
    public class EFProductRepository : EFEntityRepository<Product, ApplicationDbContext>, IProductRepository
    {
    }
}
