using DDS.LocaDorr.Common.Entities;

namespace DDS.LocaDorr.Common.Persistence.Repositories;

public interface ICreatableRepository<TEntity> where TEntity : BaseEntity
{
    void Create(TEntity entity);
}