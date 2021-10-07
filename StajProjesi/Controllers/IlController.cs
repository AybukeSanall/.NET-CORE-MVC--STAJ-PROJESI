using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StajProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajProjesi.Controllers
{
    public class IlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
