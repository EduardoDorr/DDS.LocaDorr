using DDS.LocaDorr.Common.Entities;

namespace DDS.LocaDorr.Common.Persistence.Repositories;

public interface IGenericRepository<TEntity>
    : IReadableRepository<TEntity>,
      ICreatableRepository<TEntity>,
      IUpdatableRepository<TEntity>,
      IDeletableRepository<TEntity> where TEntity : BaseEntity
{
}