using WierdBrainCoffee.StorageApp.Entities;

namespace WierdBrainCoffee.StorageApp.Reposatory
{
    public interface IWriteRepository<in T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetID(int id);

    }
    public interface IRepository<T> : IReadRepository<T> ,IWriteRepository<T> where T : IEntity
    {
       
       
    }
    public interface ISuperRepository<T>: IRepository<T> where T : IEntity
    {

    }
}