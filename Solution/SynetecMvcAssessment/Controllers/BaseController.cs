using SynetecServices.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterviewTestTemplatev2.Controllers
{
    public class BaseController: Controller
    {
        protected IServiceFactory ServiceFactory;
        public BaseController(IServiceFactory serviceFactory)
        {
            ServiceFactory = serviceFactory;
        }
        public BaseController()
        {
            ServiceFactory = new ServiceFactory();
        }
    }
}