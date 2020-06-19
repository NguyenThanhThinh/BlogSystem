using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSystem.Common
{
    public interface IDeletableEntityRepository<T> : IRepository<T> where T : class
    {
        IQueryable<T> AllWithDeleted();
    }
}
