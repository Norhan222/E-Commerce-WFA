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
        public IEnumerable<T> GetAll();
        public T GetById(TId pk);

        public void Create(T Entity);
        public void Delete(T Entity);
        public void Update(T Entity);
        public int Save();

    }
}
