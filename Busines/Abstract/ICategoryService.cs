using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        IDataResult<Category> GetByCategoryId(int categoryId);
        IDataResult<List<Category>> GetAll();
    }
}
