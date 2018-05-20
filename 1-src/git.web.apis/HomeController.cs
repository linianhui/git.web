using Microsoft.AspNetCore.Mvc;

namespace Git.Web.Apis
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet(Name = "home")]
        public object Index()
        {
            return new
            {
                docs_url = Url.Link("home", null) + ".docs",
                commits_url = Routes.Commits.Links.GetAll(Url)
            };
        }
    }
}
