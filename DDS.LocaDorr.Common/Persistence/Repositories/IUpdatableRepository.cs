using DDS.LocaDorr.Common.Entities;

namespace DDS.LocaDorr.Common.Persistence.Repositories;

public interface IUpdatableRepository<TEntity> where TEntity : BaseEntity
{
    void Update(TEntity entity);
}