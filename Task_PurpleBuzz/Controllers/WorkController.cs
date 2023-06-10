using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_PurpleBuzz.DAL;
using Task_PurpleBuzz.ViewModels.Work;

namespace Task_PurpleBuzz.Controllers
{
	public class WorkController : Controller
	{
		private readonly AppDbContext _context;

		public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
			var workCategories = _context.WorkCategories
										.Include(x => x.Works)
										.ToList();

			var model = new WorkIndexVM
			{
				WorkCategories = workCategories
			};
			return View(model);
		}
	}
}
