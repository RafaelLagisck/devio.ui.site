using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("produtos")]
    public class PedidosController : Controller
    {
        [Route("lista")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
