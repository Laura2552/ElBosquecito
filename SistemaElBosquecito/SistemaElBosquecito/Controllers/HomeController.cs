using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SistemaElBosquecito.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaElBosquecito.Controllers
{
    public class HomeController : Controller
    {
        // Registrar roles

        //IServiceProvider _serviceProvider;

        public HomeController(IServiceProvider serviceProvider)
        {
            //Registrar roles

           // _serviceProvider = serviceProvider;
        }

        public async Task<IActionResult> Index()
        {
            //Registrar roles

          //  await CreateRolesAsync(_serviceProvider);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task CreateRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
           
            //Verificar los roles registrados y registrar los nuevos
            String[] rolesName = { "Admin", "User" };
            foreach (var item in rolesName)
            {
                var roleExist = await roleManager.RoleExistsAsync(item);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(item));
                }

            }
            

        }

    }
}
