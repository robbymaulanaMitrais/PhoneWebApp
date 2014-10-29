using Abp.Domain.Entities;
using Abp.EntityFramework.Repositories;

namespace PhoneWebApp.EntityFramework.Repositories
{
    public abstract class PhoneWebAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PhoneWebAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class PhoneWebAppRepositoryBase<TEntity> : PhoneWebAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
