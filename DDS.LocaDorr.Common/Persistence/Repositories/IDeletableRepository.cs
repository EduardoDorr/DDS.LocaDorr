using DDS.LocaDorr.Common.Entities;

namespace DDS.LocaDorr.Common.Persistence.Repositories;

public interface IDeletableRepository<TEntity> where TEntity : BaseEntity
{
    void Delete(TEntity entity);
}