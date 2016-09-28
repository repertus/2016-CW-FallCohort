using Classroom.Core.Domain;
using Classroom.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data.Infrastructure;
using Classroom.Data.Infrastructure;

namespace Classroom.Data.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
