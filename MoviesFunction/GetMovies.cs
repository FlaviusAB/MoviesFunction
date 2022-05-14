using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using MoviesFunction.Models;
using System.Linq;

namespace MoviesFunction
{
    public static class GetMovies
    {
        [FunctionNameAttribute("getMovies")]
        public static async Task<IActionResult> GetMoviesFunction(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "movie")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Called get_movies with GET request");

            return new OkObjectResult(MovieList.movies);
        }

        [FunctionName("getMovieById")]
        public static async Task<IActionResult> GetMovieByIdFunction(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "movie/{id}")] HttpRequest req, string id,
            ILogger log)
        {
            log.LogInformation("Called Get_Movie_By_Id with get request.");

            var movie = MovieList.movies.FirstOrDefault(m => m.Id.Equals(id));
            if (movie == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(movie);
        }
    }
}

