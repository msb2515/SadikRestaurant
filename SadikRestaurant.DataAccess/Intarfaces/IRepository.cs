using SadikRestaurant.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SadikRestaurant.DataAccess.Intarfaces
{
   public interface IRepository<TEntity> where TEntity:class,IEntity,new()
    {
        void Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);
        void AddOrUpdate(TEntity entity);
        void AddOrUpdate(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> filter);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
        bool Exits(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> Filter,params Expression<Func<TEntity, object>>[] includes);
        IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> Selector,params Expression<Func<TEntity, TEntity>>[] includes);
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> Selector,params Expression<Func<TEntity, TResult>>[] includes);
        void Load(Expression<Func<TEntity, bool>> Filter, params Expression<Func<TEntity, object>>[] includes);
        bool HasChanges();
        BindingList<TEntity> BindingList();
    }
}
