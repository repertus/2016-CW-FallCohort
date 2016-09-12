using Classroom.Core.Infrastructure;
using Classroom.Data.Infrastructure;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Todo.Data.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected IDatabaseFactory DatabaseFactory;

        private ClassroomDataContext _dataContext;
        protected ClassroomDataContext DataContext => _dataContext ?? (_dataContext = DatabaseFactory.GetDataContext());

        protected IDbSet<T> DbSet { get; set; }

        public Repository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;

            DbSet = DataContext.Set<T>();
        }

        // CREATE
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        // READ
        public T GetById(object id)
        {
            return DbSet.Find(id);
        }
        public IQueryable<T> GetAll()
        {
            return DbSet;
        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> lambda)
        {
            return DbSet.Where(lambda);
        }
        public int Count()
        {
            return DbSet.Count();
        }
        public int Count(Expression<Func<T, bool>> lambda)
        {
            return DbSet.Count(lambda);
        }
        public bool Any(Expression<Func<T, bool>> lambda)
        {
            return DbSet.Any(lambda);
        }

        // UPDATE
        public void Update(T entity)
        {
            DbSet.Attach(entity);
            DataContext.Entry(entity).State = EntityState.Modified;
        }

        // DELETE
        public T Delete(object entityId)
        {
            var entity = GetById(entityId);
            return Delete(entity);
        }
        public T Delete(T entity)
        {
            return DbSet.Remove(entity);
        }
    }
}