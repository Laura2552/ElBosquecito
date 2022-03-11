using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaElBosquecito.Areas.Usuarios.Models;

namespace SistemaElBosquecito.Areas.Usuarios.Pages.Cuenta
{
    public class RegistrarModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel : InputModelRegistrar
        {
            public IFormFile AvatarImagen { get; set; }
        }
    }
}
