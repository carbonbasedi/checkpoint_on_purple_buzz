using Microsoft.AspNetCore.Mvc;
using System;
using Task_PurpleBuzz.DAL;
using Task_PurpleBuzz.Models;
using Task_PurpleBuzz.ViewModels.About;

namespace Task_PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var aboutBannerComponent =  _context.AboutBannerComponent.FirstOrDefault();


            var model = new AboutIndexVM
            {
                AboutBannerComponent = aboutBannerComponent
            };

            return View(model);
        }
    }
}
