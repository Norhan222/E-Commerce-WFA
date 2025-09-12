using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Interfaces
{
    public interface IGenericRepo<T, TId>
    {
        public IQueryable<T> GetAll();
        public T GetById(TId pk);

        public void createcategory(T Entity);
        public void delete(T Entity);
        public void update(T Entity);
        public int save();

    }
}
