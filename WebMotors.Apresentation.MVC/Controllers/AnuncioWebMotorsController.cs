using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebMotors.Application.Interfaces.Entities;
using WebMotors.Application.Models;

namespace WebMotors.Apresentation.MVC.Controllers
{
    public class AnuncioWebMotorsController : Controller
    {
        private readonly IAnuncioWebmotorsAppService _app;

        public AnuncioWebMotorsController(IAnuncioWebmotorsAppService app)
        {
            _app = app;
        }

        // GET: AnuncioWebMotors
        public ActionResult Index()
        {
            var anuncios = new List<AnuncioWebMotorsModel>{
                new AnuncioWebMotorsModel(1, "Chevrolet", "Prisma", "Basica", 2015, 0, ""),
                new AnuncioWebMotorsModel(2, "Honda", "Civic", "Luxo", 2018, 0, "Novo")
            };

            var lst = _app.GetAll().ToList();
            lst.AddRange(anuncios);

            return View(lst);
        }
    }
}