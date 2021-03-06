﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace MetallTrainingPlatform.Domain.Repository.Interfaces
{
    interface IGenericRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity item, CancellationToken cToken = default);
        Task<TEntity> FindByIdAsync(int id, CancellationToken cToken = default);
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cToken = default);
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cToken = default);
        Task UpdateAsync(TEntity item, CancellationToken cToken = default);
        Task RemoveAsync(TEntity item, CancellationToken cToken = default);
        Task RemoveAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cToken = default);
        Task<IEnumerable<TEntity>> GetWithIncludeAsync(CancellationToken cToken = default, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<IEnumerable<TEntity>> GetWithIncludeAsync(Func<TEntity, bool> predicate, CancellationToken cToken = default,
            params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
