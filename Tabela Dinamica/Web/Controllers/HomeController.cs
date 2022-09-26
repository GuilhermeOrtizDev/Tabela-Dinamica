using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var tables = new List<TableVO> {
                new TableVO { 
                    Model = typeof(Model1),
                    Actions = new List<Actions> { Actions.Detail },
                    Items = new List<Model1>
                    {
                        new Model1 { Id = 1, Ativo = true, Criado = DateTime.Now.AddDays(-1), Modificado = DateTime.Now, Titulo = "Linha 1" },
                        new Model1 { Id = 2, Ativo = true, Criado = DateTime.Now.AddDays(-2), Modificado = DateTime.Now, Titulo = "Linha 2" },
                        new Model1 { Id = 3, Ativo = false, Criado = DateTime.Now.AddDays(-3), Modificado = DateTime.Now, Titulo = "Linha 3" }
                    }
                },
                new TableVO {
                    Model = typeof(Model2),
                    Actions = new List<Actions> { Actions.Detail, Actions.Edit },
                    Items = new List<Model2>
                    {
                        new Model2 { Id = 1, Coluna1 = "Dado 1", Coluna2 = "Dado 2", Coluna3 = "Dado 3" },
                        new Model2 { Id = 2, Coluna1 = "Dado 4", Coluna2 = "Dado 5", Coluna3 = "Dado 6" }
                    }
                },
                new TableVO {
                    Model = typeof(Model3),
                    Actions = new List<Actions> { Actions.Detail, Actions.Edit, Actions.Delete },
                    Items = new List<Model3>
                    {
                        new Model3 { Id = 1, CampoComAcentuacao = "Dado 7", CampoComposto = "Dado 8" },
                        new Model3 { Id = 2, CampoComAcentuacao = "Dado 9", CampoComposto = "Dado 10" }
                    }
                }
            };

            return View(tables);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}