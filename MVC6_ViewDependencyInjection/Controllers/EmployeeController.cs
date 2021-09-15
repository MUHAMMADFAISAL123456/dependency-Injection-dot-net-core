using Microsoft.AspNetCore.Mvc;
using MVC6_ViewDependencyInjection.Services;
namespace MVC6_ViewDependencyInjection.Controllers
{
    public class EmployeeController : Controller
    {

        DalService dService;

        public EmployeeController(DalService s)
        {
            dService = s;
        }


        // GET: /< controller >/
        public IActionResult Index()
        {
            var data = dService.Get();
            return View(data);
        }
    }
}