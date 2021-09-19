using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EducationPortal.DataAccess.Repository
{
    interface IRepository<T> where T:class
    {
        //DbSet<T> Table { get; }
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);

        IQueryable<T> TAll();
        IQueryable<T> TWhere(Expression<Func<T, bool>> where);
        IQueryable<T> TOrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc);
    }
}
