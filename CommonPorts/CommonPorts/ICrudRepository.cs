using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommonPorts
{
    /// <summary>
    /// Repository with CRUD operations.
    /// </summary>
    public interface ICrudRepository<TId, TEntity> : IRepository<TId, TEntity>, IDataSource<TId, TEntity>, IDataSink<TId, TEntity>
    {
    }
}
