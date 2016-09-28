using Classroom.Core.Domain;
using Classroom.Core.Infrastructure;
using Classroom.Core.Repository;
using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace Classroom.API.Controllers
{
    public class StudentsController : ApiController
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StudentsController(IStudentRepository studentRepository, IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Students
        public IQueryable<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        // GET: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            Student student = _studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.StudentId)
            {
                return BadRequest();
            }

            _studentRepository.Update(student);

            try
            {
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Students
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _studentRepository.Add(student);
            _unitOfWork.Commit();

            return CreatedAtRoute("DefaultApi", new { id = student.StudentId }, student);
        }

        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            Student student = _studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            _studentRepository.Delete(student);
            _unitOfWork.Commit();

            return Ok(student);
        }

        private bool StudentExists(int id)
        {
            return _studentRepository.Any(e => e.StudentId == id);
        }
    }
}