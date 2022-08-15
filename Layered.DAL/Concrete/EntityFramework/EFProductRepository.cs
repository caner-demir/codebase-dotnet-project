using Layered.DAL.Abstract;
using Layered.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Layered.Entities.Concrete;

namespace Layered.DAL.Concrete.EntityFramework
{
    public class EFProductRepository : EFEntityRepository<Product, ApplicationDbContext>, IProductRepository
    {
    }
}
