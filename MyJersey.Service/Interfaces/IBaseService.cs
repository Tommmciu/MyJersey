using System.Collections.Generic;
using MyJersey.Entities;

namespace MyJersey.Service.Interfaces
{
    public interface IBaseService<T> where T: BaseRecord
    {
        int Add(T entity);
        void Edit(T entity);
        int Delete(T entity);
        int Delete(int id);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}