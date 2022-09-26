using PieShop.Models;
using PieShop.ViewModel;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly Models.IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(Models.IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.AllPies);
            PieListViewModel piesListViewModel = new PieListViewModel();
            piesListViewModel.Pies = (System.Collections.Generic.IEnumerable<Pie>)_pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }
    }
}
