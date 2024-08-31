﻿using System.Linq.Expressions;
using DDS.LocaDorr.Common.Entities;

namespace DDS.LocaDorr.Common.Persistence.Repositories;

public interface IReadableByRepository<TEntity> where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> GetAllByAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    Task<TEntity?> GetSingleByAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
}