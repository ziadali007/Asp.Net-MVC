using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class MovieController : Controller
    {
        //public string GetMovies(int id)
        //{
        //    return $"Get Movie With Id {id}";
        //}

        //public ContentResult GetMovies(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id {id}",
        //        ContentType = "text/plain",
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}

        //public ContentResult GetMovies(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie With Id {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}

        //public RedirectResult GetMovies()
        //{
        //    return Redirect("https://www.google.com");
        //}

        //public RedirectToActionResult GetMovies()
        //{
        //    return RedirectToAction("AddMovies","Movie",new {id=133});
        //}

        [ActionName("Movies")]
        public IActionResult GetMovies(int id)
        {
            if (id == 1)
            {
                return new ContentResult()
                {
                    Content = $"Get Movie With Id {id}",
                    ContentType = "text/plain",
                    StatusCode = 200
                };
            }
            else if (id == 2)
            {
                return new RedirectResult("https://www.google.com");
            }
            else
            {
                return RedirectToAction("AddMovies", "Movie", new { id = 133 });
            }

        }


        public string AddMovies(int id)
        {
            return $"Add Movie With Id {id}";
        }

    }
}
