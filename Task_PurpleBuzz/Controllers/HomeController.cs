using Microsoft.AspNetCore.Mvc;
using Task_PurpleBuzz.DAL;
using Task_PurpleBuzz.Models;
using Task_PurpleBuzz.ViewModels.Home;

namespace Task_PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
		private readonly AppDbContext _context;

		public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var serviceComponent = _context.ServiceComponents.FirstOrDefault(sc => !sc.IsDeleted);

            var model = new HomeIndexVM
            {
                ServiceComponent = serviceComponent
            };

            return View(model);
        }
    }
}
