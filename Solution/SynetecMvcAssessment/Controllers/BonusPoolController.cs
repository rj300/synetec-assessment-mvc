using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewTestTemplatev2.Models;
using SynetecRepositories.Factory;
using SynetecServices.Factory;

namespace InterviewTestTemplatev2.Controllers
{
    
    public class BonusPoolController : BaseController
    {
        public BonusPoolController(IServiceFactory serviceFactory) : base(serviceFactory)
        {
        }

        // GET: BonusPool
        public ActionResult Index()
        {
            var result = new BonusPoolCalculatorModel
            {
                AllEmployees = ServiceFactory.GetEmployeesService().GetAll()
            };

            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(BonusPoolCalculatorModel model)
        {
            BonusPoolCalculatorResultModel result = new BonusPoolCalculatorResultModel
            {
                hrEmployee = ServiceFactory.GetEmployeesService().Get(model.SelectedEmployeeId),
                bonusPoolAllocation = ServiceFactory.GetCalculateBonusService().CalculateEmployeeBonusPoolAllocation(model.SelectedEmployeeId, model.BonusPoolAmount)
            };
            
            return View(result);
        }
    }
}