using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using System.Linq;

namespace MovieApp.Controllers
{
    public class MovieController:Controller
    {
        public IActionResult Index(int? id, string category = "")
        {
            var movies = MovieRepository.Movies;
            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).OrderBy(m => m.Name).ToList();
            }
            if (!string.IsNullOrEmpty(category))
            {
                ViewBag.Category = category;
            }

            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }

        public IActionResult List()
        {
            return View();
        }
    }
}