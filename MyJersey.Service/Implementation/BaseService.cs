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
            _context.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public void Edit(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public int Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public int Delete(int id)
        {
            var entity= _context.Set<T>().FirstOrDefault(x => x.Id == id);
            if (entity is null) throw new ArgumentException($"Can not find entity with id: {id}.", nameof(id));
             return Delete(entity);
        }

        public T Get(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }
    }
}
