using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseData = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99m
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseData = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99m
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseData = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99m
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseData = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "NR",
                    Price = 3.99m
                },
                //1
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseData = DateTime.Parse("1972-3-24"),
                    Genre = "Crime",
                    Rating = "R",
                    Price = 16.99m
                },
                //2
                new Movie
                {
                    Title = "Scarface",
                    ReleaseData = DateTime.Parse("1983-12-09"),
                    Genre = "Crime/Thriller",
                    Rating = "R",
                    Price = 14.99m
                },
                //3
                new Movie
                {
                    Title = "Limitless",
                    ReleaseData = DateTime.Parse("2011-3-8"),
                    Genre = "Thriller/Sci-fi",
                    Rating = "PG-13",
                    Price = 7.99m
                }
            );
            context.SaveChanges();
        }
    }
}