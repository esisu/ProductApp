using ProductApp.Domain.Common;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();

        Task<T?> GetById(Guid id);

        Task<T> AddAsync(T entity);
    }
}
