using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageBlog.Web.Data;
using RazorPageBlog.Web.Models.Domain;

namespace RazorPageBlog.Web.Pages.Admin.Blogs
{
    public class ListModel : PageModel
    {
        private readonly BlogDbContext _blogDbContext;

        public List<BlogPost> BlogPosts { get; set; }

        public ListModel(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public void OnGet()
        {
           BlogPosts = _blogDbContext.BlogPosts.ToList();
        }
    }
}
