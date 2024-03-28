using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Dal => Data Access Layer veya Dao kullanılır.
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
