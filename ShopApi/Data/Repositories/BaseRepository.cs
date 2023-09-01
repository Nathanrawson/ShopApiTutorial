using Microsoft.EntityFrameworkCore;
using ShopApi.Data.EntityModels.Interfaces;
using ShopApi.Data.Repositories.Interfaces;

namespace ShopApi.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            T? entity =_context.Set<T>().FirstOrDefault(x => x.Id == id) ?? new T();
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id) ?? new T();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
