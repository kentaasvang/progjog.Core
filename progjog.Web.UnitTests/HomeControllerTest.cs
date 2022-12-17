using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using progjog.Web.Controllers;
using progjog.Web.Data.Repositories;
using progjog.Web.Models;
using progjog.Web.UnitTests.Fakers;
using Xunit;

namespace progjog.Web.UnitTests;

public class HomeControllerTest
{
    [Fact]
    public void Index_ReturnsAViewResult_WithAListOfTrainingPlans()
    {
        // Arrange
        var loggerMock = Mock.Of<ILogger<HomeController>>();
        var trainingPlanRepo = new Mock<ITrainingPlanRepository>();

        var trainingPlanViewModels = TrainingPlanViewModelFaker.Create().Generate(5);

        trainingPlanRepo.Setup(repo => repo.GetAll()).Returns(trainingPlanViewModels).Verifiable();
        
        var controller = new HomeController(loggerMock, trainingPlanRepo.Object);

        // Act
        var result = controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        var model = Assert.IsAssignableFrom<List<TrainingPlanViewModel>>(viewResult.ViewData.Model);
        trainingPlanRepo.Verify();
    }
}