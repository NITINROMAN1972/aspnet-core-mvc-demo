using Election_PMS.Data;
using Election_PMS.Models.Domain;
using Election_PMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Election_PMS.Controllers
{
    public class AdminTagController : Controller
    {
        // constrcutor injection for conenction string
        private readonly BlogDbContext blogDbContext;
        public AdminTagController(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            var tag = new Tag {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            blogDbContext.Tags.Add(tag);
            blogDbContext.SaveChanges();

            return View("Add");
        }
    }
}
