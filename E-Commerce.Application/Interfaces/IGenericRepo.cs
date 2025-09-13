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
<<<<<<< HEAD

        public void Create(T Entity);
        public void Delete(T Entity);
        public void Update(T Entity);
        public int Save();

=======
        public void CreateRepo(T Entity);
        public void DeleteRepo(T Entity);
        public void UpdateRepo(T Entity);
        public int SaveRepo();
>>>>>>> fedcc878f2a5a737932d817d8d78a2909cf62096
    }
}
