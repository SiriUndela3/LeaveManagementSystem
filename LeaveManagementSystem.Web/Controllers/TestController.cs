using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "student",
                DateOfBirth = new DateTime(1999, 04, 18)
            };
            return View(data);
        }
    } // Testing Git changes
}
