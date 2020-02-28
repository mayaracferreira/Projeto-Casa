using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasaShow.Models;
using CasaShow.Data;
using Microsoft.EntityFrameworkCore;

namespace CasaShow.Controllers
{
    public class HomeController : Controller
    {

         public readonly ApplicationsDbContext database;

    
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationsDbContext database)
        {
                this.database = database;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View ();
        }

        public IActionResult Ingressos()
        {
            return View();
        }

       



        public IActionResult Contato(){
        
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
