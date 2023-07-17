using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using NimbusSync.Models.Domain;
using NimbusSync.Models.DTO;
using NimbusSync.Server.Controllers;
using NimbusSync.Server.Repositories;

namespace NimbusSync.Server.Tests
{
    public class AuthControllerTests
    {
        [Fact]
        public async void Register_AccountDoesNotExist_ReturnsToken()
        {
            // Arrange
            Mock<IAuthRepository> mockedRepo = new Mock<IAuthRepository>();
            RegisterAccountRequest registerAccountRequest = new RegisterAccountRequest("Carlos", "carlos@supercomapany.com.br", "Sp123_554", new List<Account.PrivilageTypes> { Account.PrivilageTypes.ReadFile, Account.PrivilageTypes.WriteFile });

            const string TOKEN = "certin";

            mockedRepo.Setup(mr => mr.RegisterAsync("Carlos", "carlos@supercomapany.com.br", "Sp123_554", new List<Account.PrivilageTypes> { Account.PrivilageTypes.ReadFile, Account.PrivilageTypes.WriteFile }))
                .Returns(Task.FromResult<string?>(TOKEN));

            AuthController authController = new AuthController(mockedRepo.Object);

            // Action 
            IActionResult result = await authController.RegisterAsync(registerAccountRequest);

            // Assert
            OkObjectResult okObjectResult = result.Should().BeOfType<OkObjectResult>().Subject;
            okObjectResult.Value.Should().Be(TOKEN);
        }

        [Fact]
        public async void Login_AccountExists_ReturnsToken()
        {
            // Arrange
            Mock<IAuthRepository> mockedRepo = new Mock<IAuthRepository>();

            const string TOKEN = "certin";

            mockedRepo.Setup(mr => mr.AuthenticateAsync("carlos@supercomapany.com.br", "Sp123_554"))
                .Returns(Task.FromResult<string?>(TOKEN));

            AuthController authController = new AuthController(mockedRepo.Object);
            LoginAccountRequest loginAccountRequest = new LoginAccountRequest("carlos@supercomapany.com.br", "Sp123_554");

            // Action 
            IActionResult result = await authController.LoginAsync(loginAccountRequest);

            // Assert
            OkObjectResult okObjectResult = result.Should().BeOfType<OkObjectResult>().Subject;
            okObjectResult.Value.Should().Be(TOKEN);
        }

        [Fact]
        public async void Register_AccountExists_ReturnsBadRequest()
        {
            // Arrange
            Mock<IAuthRepository> mockedRepo = new Mock<IAuthRepository>();
            RegisterAccountRequest registerAccountRequest = new RegisterAccountRequest("Carlos" ,"carlos@supercomapany.com.br", "Sp123_554", new List<Account.PrivilageTypes> { Account.PrivilageTypes.ReadFile, Account.PrivilageTypes.WriteFile });

            mockedRepo.Setup(mr => mr.RegisterAsync("Carlos", "carlos@supercomapany.com.br", "Sp123_554", new List<Account.PrivilageTypes> { Account.PrivilageTypes.ReadFile, Account.PrivilageTypes.WriteFile }))
                .Returns(Task.FromResult<string?>(null));

            AuthController authController = new AuthController(mockedRepo.Object);

            // Action 
            IActionResult result = await authController.RegisterAsync(registerAccountRequest);

            // Assert
            BadRequestObjectResult badObjectResult = result.Should().BeOfType<BadRequestObjectResult>().Subject;
        }

        [Fact]
        public async void Login_AccountDoesNotExists_ReturnsBadRequest()
        {
            Mock<IAuthRepository> mockedRepo = new Mock<IAuthRepository>();
            LoginAccountRequest loginAccountRequest = new LoginAccountRequest("carlos@supercomapany.com.br", "Sp123_554");

            mockedRepo.Setup(mr => mr.AuthenticateAsync("carlos@supercomapany.com.br", "Sp123_554"))
                .Returns(Task.FromResult<string?>(null));

            AuthController authController = new AuthController(mockedRepo.Object);

            // Action 
            IActionResult result = await authController.LoginAsync(loginAccountRequest);

            // Assert
            BadRequestObjectResult badObjectResult = result.Should().BeOfType<BadRequestObjectResult>().Subject;
        }
    }
}
