using Microsoft.EntityFrameworkCore;
using WierdBrainCoffee.StorageApp.Entities;

namespace WierdBrainCoffee.StorageApp.Reposatory
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity//If you write T : class, IEntity it can be nullable otherWise It can't be nullable
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        //public T CreateItems()
        //{
        //    return new T();
        //}

        public T GetID(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }


        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id).ToList();
        }

    }


}
