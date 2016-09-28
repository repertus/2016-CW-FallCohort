using Classroom.Core.Domain;
using Classroom.Core.Repository;
using Classroom.Data.Infrastructure;
using Todo.Data.Infrastructure;

namespace Classroom.Data.Repository
{
    public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(IDatabaseFactory df) : base(df)
        {

        }
    }
}
