using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NimbusSync.Models.Domain;
using NimbusSync.Models.DTO;
using NimbusSync.Server.Controllers;
using NimbusSync.Server.Repositories;

namespace NimbusSync.Server.Tests
{
    public class TecnicalDrawControllerTests
    {
        [Fact]
        public async void GetTecnicalDrawAsync_TecnicalDrawExists_ReturnsTecnicalDraw()
        {
            // Arrange
            Mock<ITecnicalDrawRepository> mockedRepo = new Mock<ITecnicalDrawRepository>();
            Mock<IMapper> mockedMapper = new Mock<IMapper>();

            TecnicalDraw tecnicalDraw = new TecnicalDraw() { Code = "1234", File = new byte[0] };
            TecnicalDrawDTO tecnicalDrawDTO = new TecnicalDrawDTO() { Code = "1234", File = new byte[0] };
            
            mockedRepo.Setup(x => x.GetTecnicalDrawAsync("1234")).Returns(Task.FromResult(tecnicalDraw));
            mockedMapper.Setup(m => m.Map<TecnicalDrawDTO>(tecnicalDraw)).Returns(tecnicalDrawDTO);

            TecnicalDrawsController tecnicalDrawsController = new TecnicalDrawsController(mockedRepo.Object, mockedMapper.Object);

            // Act
            var response = await tecnicalDrawsController.GetTecnicalDrawAsync("1234");

            // Assert
            var result = Assert.IsType<OkObjectResult>(response);
            var responseDTO = result.Value.Should().BeOfType<TecnicalDrawDTO>().Subject;
            responseDTO.Should().BeEquivalentTo(tecnicalDrawDTO);
        }

        [Fact]
        public async void GetTecnicalDrawAsync_TecnicalDrawDoesNotExists_ReturnsBadRequest()
        {
            // Arrange
            Mock<ITecnicalDrawRepository> mockedRepo = new Mock<ITecnicalDrawRepository>();

            mockedRepo.Setup(mr => mr.GetTecnicalDrawAsync("1234")).Returns(Task.FromResult<TecnicalDraw>(null));

            TecnicalDrawsController tecnicalDrawsController = new TecnicalDrawsController(mockedRepo.Object, null);

            // Action
            IActionResult actionResult = await tecnicalDrawsController.GetTecnicalDrawAsync("1234");
            
            // Assert
            actionResult.Should().BeOfType<NotFoundResult>();
        }
    }
}
