using System;
using System.Linq;
using System.Linq.Expressions;

namespace Classroom.Core.Infrastructure
{
    public interface IRepository<EntityType> where EntityType : class
    {
        // CREATE
        void Add(EntityType entity);

        // READ
        EntityType GetById(object id);
        IQueryable<EntityType> GetAll();
        IQueryable<EntityType> GetWhere(Expression<Func<EntityType, bool>> lambda);
        int Count();
        int Count(Expression<Func<EntityType, bool>> lambda);
        bool Any(Expression<Func<EntityType, bool>> lambda);

        // UPDATE
        void Update(EntityType entity);

        // DELETE
        EntityType Delete(object entityId);
        EntityType Delete(EntityType entity);
    }
}