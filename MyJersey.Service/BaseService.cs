using System;

namespace MyJersey.Service
{
    public class BaseService<T> : IBaseService<T> where T : new()
    {
        public int Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
