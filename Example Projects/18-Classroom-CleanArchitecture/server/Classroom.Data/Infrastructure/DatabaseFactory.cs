using System.Data.Entity;

namespace Classroom.Data.Infrastructure
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private ClassroomDataContext dataContext;

        public DatabaseFactory()
        {
            dataContext = new ClassroomDataContext();
        }

        public ClassroomDataContext GetDataContext()
        {
            return dataContext ?? new ClassroomDataContext();
        }
    }
}
