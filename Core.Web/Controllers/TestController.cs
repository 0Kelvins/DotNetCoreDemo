using Core.Model.Entity;
using Core.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Controllers {

    [Route("test")]
    public class TestController : Controller {

        private ITestService service;

        public TestController(ITestService service)
        {
            this.service = service;
        }

        [Route("getUser")]
        public JsonResult GetUser(){
            User user = service.GetUser();
            return Json(user);
        }
    }
}