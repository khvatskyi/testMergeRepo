using Microsoft.AspNetCore.Mvc;
using Sprint12_MVC.Services;
using Sprint12_MVC.Models;
using System.Diagnostics;

namespace Sprint12_MVC.Controllers
{
    public class TriangleController : Controller
    {
        public ITriangleService TriangleService { get; }

        public TriangleController(ITriangleService TriangleService)
            => this.TriangleService = TriangleService;

        public IActionResult Index()
            => View("~/Views/Home/Index.cshtml");

        public ActionResult<bool> IsRightAngled(Triangle triangle)
            => ModelState.IsValid ? TriangleService.IsRightAngled(triangle) : (ActionResult<bool>)View("error");
        
        public ActionResult<bool> IsEquilateral(Triangle triangle)
            => ModelState.IsValid ? TriangleService.IsEquilateral(triangle) : (ActionResult<bool>)View("error");

        public ActionResult<bool> IsIsosceles(Triangle triangle)
            => ModelState.IsValid ? TriangleService.IsIsosceles(triangle) : (ActionResult<bool>)View("error");

        public ActionResult<bool> AreCongruent(Triangle tr1, Triangle tr2)
            => ModelState.IsValid ? TriangleService.AreCongruent(tr1, tr2) : (ActionResult<bool>)View("error");

        public ActionResult<bool> AreSimilar(Triangle tr1, Triangle tr2)
            => ModelState.IsValid ? TriangleService.AreSimilar(tr1, tr2) : (ActionResult<bool>)View("error");
    }
}
