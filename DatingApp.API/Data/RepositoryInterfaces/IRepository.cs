using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data.RepositoryInterfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllWithInclude<P>(Expression<Func<T, P>> predicate);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetEntity(int id);
        Task<T> GetEntityWithInclude<P>(Expression<Func<T, P>> predicate, Expression<Func<T, bool>> predicate2);
    }
}