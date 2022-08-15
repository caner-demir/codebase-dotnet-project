using Layered.Core.DataAccess;
using Layered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.DAL.Abstract
{
    public interface IProductRepository : IEntityRepository<Product>
    {
    }
}
