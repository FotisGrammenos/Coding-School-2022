using Model;

namespace Gas_Station.EF.Repos
{
    public interface IEntityRepo<TEntity> where TEntity : BaseEntitie
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity?>GetByIdAsynv(Guid id);

        Task AddAsync(TEntity entity);

        Task UpdateAsync(Guid id, TEntity entity);
        
        Task DeleteAsync(Guid id);
    }
}