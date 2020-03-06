using Moq;
using NUnit.Framework;
using SynetecDatabase.Data;
using SynetecMvcAssessment.Services.Interfaces;
using SynetecRepositories.Factory;
using SynetecRepositories.Interfaces;
using SynetecServices.Factory;
using System;

namespace SynetecMvcAssessment.Services.Tests
{
    [TestFixture]
    public class CalculateBonusServiceTests
    {
        private Mock<IBaseSynetecRepoFactory> MockBaseRepositoryFactory;
        private Mock<IServiceFactory> MockServiceFactory;
        private Mock<IEmployeeRepository> MockEmployeeRepository;
        private Mock<IOrganisationRepository> MockOrganisationRepository;
        
        [SetUp]
        public void Init()
        {
            MockBaseRepositoryFactory = new Mock<IBaseSynetecRepoFactory>();
            MockServiceFactory = new Mock<IServiceFactory>();
            MockEmployeeRepository = new Mock<IEmployeeRepository>();
            MockOrganisationRepository = new Mock<IOrganisationRepository>();
        }

        [Test]
        [TestCase(98214, 654750, 123456, 18518.40)]
        [TestCase(10000, 100000, 50000, 5000.00)]
        public void TestCalculateBonus(int empSalary, int organisationSalary, int bonusAllocation, decimal expectedResult)
        {
            MockEmployeeRepository.Setup((x => x.Get(It.IsAny<int>()))).Returns(new HrEmployee()
            {
                ID = 1,
                FistName = "Test",
                SecondName = "Fixture",
                DateOfBirth = new DateTime(1990, 4, 23),
                HrDepartmentId = 1,
                JobTitle = "Software Developer",
                Salary = empSalary
            });
            MockOrganisationRepository.Setup((x => x.GetOrganisationTotalSalary())).Returns(organisationSalary);
            MockBaseRepositoryFactory.Setup((x => x.OrganisationRepository())).Returns(MockOrganisationRepository.Object);
            MockBaseRepositoryFactory.Setup((x => x.EmployeeRepository())).Returns(MockEmployeeRepository.Object);

            var calculateService = new CalculateBonusService(MockBaseRepositoryFactory.Object, MockServiceFactory.Object);

            decimal test = calculateService.CalculateEmployeeBonusPoolAllocation(1, bonusAllocation);

            Assert.AreEqual(expectedResult, test);
        }
    }
}