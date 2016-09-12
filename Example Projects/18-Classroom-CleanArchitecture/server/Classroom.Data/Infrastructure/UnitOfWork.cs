using Classroom.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _databaseFactory;

        private ClassroomDataContext _dbContext;
        private ClassroomDataContext DataContext
        {
            get
            {
                return _dbContext ?? (_dbContext = _databaseFactory.GetDataContext());
            }
        }

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }
    }
}
