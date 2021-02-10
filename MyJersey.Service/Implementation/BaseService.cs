using System;
using System.Collections.Generic;
using System.Linq;
using MyJersey.Database;
using MyJersey.Entities;
using MyJersey.Service.Interfaces;

namespace MyJersey.Service.Implementation
{
    public class BaseService<T> : IBaseService<T> where T : BaseRecord
    {
        private readonly MyJerseyDbContext _context;

        public BaseService(MyJerseyDbContext context)
        {
            _context = context;
        }
        public int Add(T entity)
        {
            return _context.Add(entity).Entity.Id;
        }

        public void Edit(T entity)
        {
            _context.Update(entity);
        }

        public int Delete(T entity)
        {
            return _context.Remove(entity).Entity.Id;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return _context.Set<T>().First(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }
    }
}
