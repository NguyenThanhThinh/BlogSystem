using BlogSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSystem.Data.Repositories
{
    public class DeletableEntityRepository<T> : GenericRepository<T>, IDeletableEntityRepository<T>
         where T : class, IDeletableEntity
    {
        public DeletableEntityRepository(IApplicationDbContext context)
            : base(context)
        {
        }

        public override IQueryable<T> All()
        {
            return base.All().Where(x => !x.IsDeleted);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return base.All();
        }
    }
}
