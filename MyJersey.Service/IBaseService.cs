namespace MyJersey.Service
{
    public interface IBaseService<T> where T: new()
    {
        int Add(T entity);
        T Edit(T entity);
        int Delete(T entity);
        T Get(int id);
    }
}