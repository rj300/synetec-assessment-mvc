using Moq;
using NUnit.Framework;
using SynetecDatabase.Data;
using SynetecMvcAssessment.Services.Interfaces;
using SynetecRepositories.Factory;
using SynetecServices.Factory;
using System;

namespace SynetecMvcAssessment.Services.Tests
{
    [TestFixture]
    public class CalculateBonusServiceTests
    {
        private ICalculateBonusService CalculateBonusService;
        private Mock<IBaseSynetecRepoFactory> MockBaseRepositoryFactory;
        private Mock<IServiceFactory> MockServiceFactory;
        
        [SetUp]
        public void Init()
        {
            CalculateBonusService = new CalculateBonusService();
            MockBaseRepositoryFactory = new Mock<IBaseSynetecRepoFactory>();
            MockServiceFactory = new Mock<IServiceFactory>();
        }

        [Test]
        public void TestCalculateBonus()
        {
            decimal test = CalculateBonusService.CalculateEmployeeBonusPoolAllocation(1, 123456);
            MockBaseRepositoryFactory.Setup((x => x.EmployeeRepository().Get(It.IsAny<int>()))).Returns(new HrEmployee()
            {
                ID = 1,
                FistName = "Test",
                SecondName = "Fixture",
                DateOfBirth = new DateTime(1990, 4, 23),
                HrDepartmentId = 1,
                JobTitle = "Software DEveloper",
                Salary = 98214
            });

            
            Assert.AreEqual(18518.40m, test);
        }
    }
}