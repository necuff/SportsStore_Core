using Microsoft.AspNetCore.Mvc;

namespace SportsStore_Core.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}
