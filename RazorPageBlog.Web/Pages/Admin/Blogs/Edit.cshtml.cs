using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageBlog.Web.Data;
using RazorPageBlog.Web.Models.Domain;

namespace RazorPageBlog.Web.Pages.Admin.Blogs
{
    public class EditModel : PageModel
    {
        private readonly BlogDbContext _blogDbContext;

        public BlogPost BlogPost { get; set; }
        public EditModel(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;  
        }
        public void OnGet(Guid id)
        {
            BlogPost = _blogDbContext.BlogPosts.Find(id);
          
        }
    }
}
