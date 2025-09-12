using E_Commerce.Application;
using E_Commerce.Core.Entites;
using E_Commerce.Infrastrucrure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastrucrure.Repositories
{
    public class GenericRepository<T, TId> : IGenericRepo<T, TId> where T : BaseModel<TId>
    {
        AppDbContext _context;
        DbSet<T> _Dbset;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _Dbset = _context.Set<T>();
        }

        public void createcategory(T Entity)
        {
            _Dbset.Add(Entity);
        }

        public void delete(T Entity)
        {
            _Dbset.Remove(Entity);
        }

        public IQueryable<T> GetAll()
        {
            return _Dbset;
        }

        public T GetById(TId pk)
        {
            return _Dbset.Find(pk);
        }

        public int save()
        {
            return _context.SaveChanges();
        }

        public void update(T Entity)
        {
            _Dbset.Update(Entity);
        }
    }
}
