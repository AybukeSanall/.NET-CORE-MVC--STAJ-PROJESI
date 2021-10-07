using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using StajProjesi.Data.Entities;
using StajProjesi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace StajProjesi.Controllers
{
    public class HomeController : Controller
    {
        //UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager

        private readonly ILogger<HomeController> _logger;
        private Data.StajProjesiContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public HomeController(ILogger<HomeController> logger, Data.StajProjesiContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index(string search)
        {
            var userAdmin = new IdentityInitializer();
            //var usr = _userManager.FindByNameAsync("aybuke");
            userAdmin.OlusturAdminAsync(_userManager, _roleManager); 
            //var usrAdminReturnDt = userAdmin.OlusturAdminAsync(_userManager, _roleManager);

            Models.SehirAramaViewModel model = new Models.SehirAramaViewModel();

            //ViewBag.Search = string.Format(" {0} GENÇLİK MERKEZLERİ", search).ToUpper();

            //using(var db = new Data.StajProjesiContext() )
            //{
            model.Sehirler = _context.Illers.Where(s => s.Sehiradi.Contains(search))
                .Include(s=>s.SehiridIlcelers)
                .ToList();


            //model.Ilceler = _context.Ilcelers.ToList();
            //model.Ilceler = _context.Ilcelers.ToList();
            //}
           
            return View(model);
        }

        public IActionResult Iletisim()
        {
            Models.IletisimViewModel iletisimViewModel = new Models.IletisimViewModel();
            return View(iletisimViewModel);
        }

        public IActionResult Sehir()
        {
            Models.SehirGosterViewModel sehirGosterViewModel = new Models.SehirGosterViewModel();
            return View(sehirGosterViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None,NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
