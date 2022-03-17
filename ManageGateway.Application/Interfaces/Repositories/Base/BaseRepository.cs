namespace ManageGateway.Application.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetByIdAsync(string id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
