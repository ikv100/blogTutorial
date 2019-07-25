using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MiVista()
        {
            return View();
        }

        // permite pasar información al servidor
        [HttpPost] 
        public ActionResult About(string email)
        {
            ViewBag.Message = "Your application description page.";

            // ViewBag es un objeto variable
            // vamos a pasar un modelo MVC
            // el modelo se llama usuario

            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario {Email = email, Nombre = "Ignacio"},
                new Usuario {Email = "Juan@mail.com", Nombre = "Juan"}
            };
            return View(usuarios);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Ignacio Vergara es el dueño.";

            return View();
        }
    }

    public class Usuario
    {
        public string Email { get; set; }
        public string Nombre { get; set; }

        public void SendEmail()
        {
            // enviamos el correo
        }
    }

}