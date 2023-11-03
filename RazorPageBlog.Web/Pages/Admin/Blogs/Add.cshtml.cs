using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageBlog.Web.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var heading = Request.Form["heading"]; // "heading" is the name of the input
            var pageTitle = Request.Form["pageTitle"]; 
            var content = Request.Form["content"]; 
            var shortDescription = Request.Form["shortDescription"]; 
            var featuredImage = Request.Form["featuredImage"]; 
        }
    }
}
