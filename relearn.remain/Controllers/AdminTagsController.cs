using Microsoft.AspNetCore.Mvc;
using relearn.remain.Data;
using relearn.remain.Models.Domain;
using relearn.remain.Models.ViewModels;

namespace relearn.remain.Controllers
{
    public class AdminTagsController : Controller
    {
        private RealearnDbContext _realearnDbContext;
        public AdminTagsController(RealearnDbContext realearnDbContext)
        {
            _realearnDbContext = realearnDbContext;
        }
        //annotation
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest) {
            // make use of dbContext to save our tag to database
            //var name = addTagRequest.Name;
            //var displayName = addTagRequest.DisplayName;

            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };


            _realearnDbContext.Tags.Add(tag);
            _realearnDbContext.SaveChanges();
            return View("Add");
        }
    }
}
