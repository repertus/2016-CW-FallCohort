using Classroom.Core.Domain;
using Classroom.Core.Repository;
using Classroom.Data.Infrastructure;
using Todo.Data.Infrastructure;

namespace Classroom.Data.Repository
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(IDatabaseFactory df) : base(df)
        {

        }
    }
}
