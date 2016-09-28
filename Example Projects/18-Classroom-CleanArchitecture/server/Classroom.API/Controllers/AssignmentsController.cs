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
    public class AssignmentsController : ApiController
    {
        private readonly IAssignmentRepository _assignmentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AssignmentsController(IAssignmentRepository assignmentRepository, IUnitOfWork unitOfWork)
        {
            _assignmentRepository = assignmentRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Assignments
        public IQueryable<Assignment> GetAssignments()
        {
            return _assignmentRepository.GetAll();
        }

        // GET: api/Assignments/5
        [ResponseType(typeof(Assignment))]
        public IHttpActionResult GetAssignment(int id)
        {
            Assignment assignment = _assignmentRepository.GetById(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return Ok(assignment);
        }

        // PUT: api/Assignments/5
        [ResponseType(typeof(void))]
        [HttpPut, Route("api/assignments/{studentId}/{projectId}")]
        public IHttpActionResult PutAssignment(int studentId, int projectId, Assignment assignment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (studentId != assignment.StudentId && projectId != assignment.ProjectId)
            {
                return BadRequest();
            }

            _assignmentRepository.Update(assignment);

            try
            {
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                if (!AssignmentExists(studentId, projectId))
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

        // POST: api/Assignments
        [ResponseType(typeof(Assignment))]
        public IHttpActionResult PostAssignment(Assignment assignment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _assignmentRepository.Add(assignment);

            try
            {
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                if (AssignmentExists(assignment.StudentId, assignment.ProjectId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = assignment.StudentId }, assignment);
        }

        // DELETE: api/Assignments/5
        [ResponseType(typeof(Assignment))]
        public IHttpActionResult DeleteAssignment(int id)
        {
            Assignment assignment = _assignmentRepository.GetById(id);
            if (assignment == null)
            {
                return NotFound();
            }

            _assignmentRepository.Delete(assignment);
            _unitOfWork.Commit();

            return Ok(assignment);
        }

        private bool AssignmentExists(int studentId, int projectId)
        {
            return _assignmentRepository.Any(a => a.StudentId == studentId && a.ProjectId == projectId);
        }
    }
}