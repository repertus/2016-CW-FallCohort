using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classroom.API.Controllers;
using Moq;
using Classroom.Core.Repository;
using Classroom.Core.Infrastructure;
using Classroom.Core.Domain;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using System.Net;

namespace Classroom.API.Test.Controllers
{
    [TestClass]
    public class ProjectsControllerTests
    {
        private ProjectsController _projectsController;
        private Mock<IProjectRepository> _mockProjectRepository;
        private Mock<IUnitOfWork> _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            // ARRANGE
            _mockProjectRepository = new Mock<IProjectRepository>();
            _unitOfWork = new Mock<IUnitOfWork>();

            _projectsController = new ProjectsController(
                _mockProjectRepository.Object,
                _unitOfWork.Object
            );
        }

        [TestMethod]
        public void GetProjectsShouldReturnAllProjects()
        {
            // ARRANGE
            _mockProjectRepository.Setup(pr => pr.GetAll())
                .Returns(new Project[]
                {
                    new Project(),
                    new Project(),
                    new Project()
                }.AsQueryable());

            // ACT
            var projects = _projectsController.GetProjects();

            // ASSERT
            Assert.IsNotNull(projects);
            Assert.AreEqual(3, projects.Count());
        }

        [TestMethod]
        public void GetProjectShouldReturnProject()
        {
            // ARRANGE
            _mockProjectRepository.Setup(pr => pr.GetById(1))
                .Returns(new Project { ProjectId = 1 });

            // ACT
            IHttpActionResult result = _projectsController.GetProject(1);
            var contentResult = result as OkNegotiatedContentResult<Project>;

            // ASSERT
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(1, contentResult.Content.ProjectId);
        }

        [TestMethod]
        public void GetProjectWithWrongIdShouldReturnNotFound()
        {
            // ARRANGE
            _mockProjectRepository.Setup(pr => pr.GetById(1))
                .Returns(new Project { ProjectId = 1 });

            // ACT
            IHttpActionResult result = _projectsController.GetProject(42);

            // ASSERT
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void UpdateProjectShouldReturnNoContentResult()
        {
            // ARRANGE

            // ACT
            IHttpActionResult actionResult = _projectsController
                .PutProject(1, new Project { ProjectId = 1, Name = "Project 1" });
            var status = actionResult as StatusCodeResult;

            // ASSERT
            Assert.IsNotNull(status);
            Assert.AreEqual(status.StatusCode, HttpStatusCode.NoContent);

        }

        [TestMethod]
        public void UpdateProjectShouldReturnBadRequest()
        {
            // ARRANGE

            // ACT
            IHttpActionResult actionResult = _projectsController
                .PutProject(1, new Project { ProjectId = 42, Name = "Project 42" });

            // ASSERT
            Assert.IsNotNull(actionResult);
            Assert.IsInstanceOfType(actionResult, typeof(BadRequestResult));
        }

        [TestMethod]
        public void PostProjectShouldReturnOk()
        {
            // ARRANGE

            // ACT
            IHttpActionResult actionResult = _projectsController
                .PostProject(new Project());

            // ASSERT
            _mockProjectRepository
                .Verify(pr => pr.Add(It.IsAny<Project>()), Times.Once);
            _unitOfWork
                .Verify(uow => uow.Commit(), Times.Once);
        }

        [TestMethod]
        public void DeleteProjectShouldReturnOk()
        {
            // ARRANGE
            _mockProjectRepository.Setup(pr => pr.GetById(1))
                .Returns(new Project { ProjectId = 1 });

            // ACT
            var actionResult = _projectsController.DeleteProject(1);
            var contentResult = actionResult as OkNegotiatedContentResult<Project>;

            // ASSERT
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(1, contentResult.Content.ProjectId);
        }

        [TestMethod]
        public void DeleteProjectShouldReturnNotFound()
        {
            // ARRANGE

            // ACT
            var contentResult = _projectsController.DeleteProject(1);

            // ASSERT
            Assert.IsInstanceOfType(contentResult, typeof(NotFoundResult));
        }
    }
}
