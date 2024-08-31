using DDS.LocaDorr.Common.Entities;
using DDS.LocaDorr.Common.Models.Pagination;

namespace DDS.LocaDorr.Common.Persistence.Repositories;

public interface IReadableRepository<TEntity> where TEntity : BaseEntity
{
    Task<PaginationResult<TEntity>> GetAllAsync(int page = 1, int pageSize = 10, CancellationToken cancellationToken = default);
    Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}