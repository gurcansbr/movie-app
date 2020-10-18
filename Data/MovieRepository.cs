using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() 
                {
                    Id=1, 
                    Name="Shazam", 
                    ShortDescription="Shazam",
                    Description="<p>We all have a superhero inside us, it just takes"+ 
                                "a bit of magic to bring it out. In Billy Batson's case,"+ 
                                "by shouting out one word - SHAZAM - this streetwise"+ 
                                "fourteen-year-old foster kid can turn into the grown-up"+ 
                                "superhero Shazam.</p>", 
                    ImageUrl="1.jpg",
                    CategoryId=1
                },
                new Movie() 
                {
                    Id=2, 
                    Name="Amazing Grace", 
                    ShortDescription="Amazing Grace",
                    Description="<p>We all have a superhero inside us, it just takes"+ 
                                "a bit of magic to bring it out. In Billy Batson's case,"+ 
                                "by shouting out one word - SHAZAM - this streetwise"+ 
                                "fourteen-year-old foster kid can turn into the grown-up"+ 
                                "superhero Shazam.</p>", 
                    ImageUrl="2.jpg",
                    CategoryId=2
                },
                new Movie() 
                {
                    Id=3, 
                    Name="High Life", 
                    ShortDescription="High Life",
                    Description="<p>We all have a superhero inside us, it just takes"+ 
                                "a bit of magic to bring it out. In Billy Batson's case,"+ 
                                "by shouting out one word - SHAZAM - this streetwise"+ 
                                "fourteen-year-old foster kid can turn into the grown-up"+ 
                                "superhero Shazam.</p>", 
                    ImageUrl="3.jpg",
                    CategoryId=2
                },
                new Movie() 
                {
                    Id=4, 
                    Name="Billboard", 
                    ShortDescription="Billboard",
                    Description="<p>We all have a superhero inside us, it just takes"+ 
                                "a bit of magic to bring it out. In Billy Batson's case,"+ 
                                "by shouting out one word - SHAZAM - this streetwise"+ 
                                "fourteen-year-old foster kid can turn into the grown-up"+ 
                                "superhero Shazam.</p>", 
                    ImageUrl="4.jpg",
                    CategoryId=3
                },
                new Movie() 
                {
                    Id=5, 
                    Name="Storm Boy", 
                    ShortDescription="Storm Boy",
                    Description="<p>We all have a superhero inside us, it just takes"+ 
                                "a bit of magic to bring it out. In Billy Batson's case,"+ 
                                "by shouting out one word - SHAZAM - this streetwise"+ 
                                "fourteen-year-old foster kid can turn into the grown-up"+ 
                                "superhero Shazam.</p>", 
                    ImageUrl="5.jpg",
                    CategoryId=3
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}