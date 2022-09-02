using PTC.Data;
using System.Web.Mvc;

namespace PTC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TrainingProductViewModel viewModel = new TrainingProductViewModel();

            viewModel.HandleRequest();
            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Index(TrainingProductViewModel viewModel)
        {
            viewModel.HandleRequest();
            ModelState.Clear();
            return View(viewModel);
        }
    }

}