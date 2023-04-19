using System.Linq.Expressions;
using OnlineStore.Domain.Entities;
using OnlineStore.Domain.Specifications;

namespace OnlineStore.DataAccess.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        void Update(T entity);
        Task<int> SaveChangesAsync();
    }

}
