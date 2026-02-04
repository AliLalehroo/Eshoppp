using Eshop.Data.Entities.Common;

namespace Eshop.Data.Repository
{
    public interface IGenericRepository<TEntity> : IAsyncDisposable where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetQuery();
        Task<TEntity> GetEntityById(long id);
        Task AddEntity(TEntity entity);
        Task AddRangeEntities(List<TEntity> entities);
        void EditEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        void DeleteEntities(List<TEntity> entities);
        void DeletePermanentEntities(List<TEntity> entities);
        Task DeletePermanent(TEntity entity);
        Task SaveAsync();
    }
}
