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
    public class ProjectsController : ApiController
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProjectsController(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            _projectRepository = projectRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Projects
        public IQueryable<Project> GetProjects()
        {
            return _projectRepository.GetAll();
        }

        // GET: api/Projects/5
        [ResponseType(typeof(Project))]
        public IHttpActionResult GetProject(int id)
        {
            Project project = _projectRepository.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        // PUT: api/Projects/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProject(int id, Project project)
        {
            if (id != project.ProjectId)
            {
                return BadRequest();
            }

            _projectRepository.Update(project);

            try
            {
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                if (!ProjectExists(id))
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

        // POST: api/Projects
        [ResponseType(typeof(Project))]
        public IHttpActionResult PostProject(Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _projectRepository.Add(project);
            _unitOfWork.Commit();

            return CreatedAtRoute("DefaultApi", new { id = project.ProjectId }, project);
        }

        // DELETE: api/Projects/5
        [ResponseType(typeof(Project))]
        public IHttpActionResult DeleteProject(int id)
        {
            Project project = _projectRepository.GetById(id);
            if (project == null)
            {
                return NotFound();
            }

            _projectRepository.Delete(project);
            _unitOfWork.Commit();

            return Ok(project);
        }

        private bool ProjectExists(int id)
        {
            return _projectRepository.Any(e => e.ProjectId == id);
        }
    }
}