using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var movies = MovieRepository.Movies;
            return View(movies);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}