using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageBlog.Web.Data;
using RazorPageBlog.Web.Models.Domain;
using RazorPageBlog.Web.Models.ViewModels;

namespace RazorPageBlog.Web.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {

        private readonly BlogDbContext _blogDbContext;

        [BindProperty]
        public AddBlogPost AddBlogPostRequest { get; set; }

        public AddModel(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext; 
        }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
          var blogPost = new BlogPost()
          {
            Heading = AddBlogPostRequest.Heading,
            PageTitle = AddBlogPostRequest.PageTitle,
            Content = AddBlogPostRequest.Content,
            ShortDescription = AddBlogPostRequest.ShortDescription,
            FeatureImageUrl = AddBlogPostRequest.FeatureImageUrl,
            UrlHandle = AddBlogPostRequest.UrlHandle,
            PublishedDate = AddBlogPostRequest.PublishedDate,
            Author = AddBlogPostRequest.Author,
            Visible = AddBlogPostRequest.Visible
          };
            _blogDbContext.BlogPosts.Add(blogPost);
            _blogDbContext.SaveChanges();


            return RedirectToPage("/admin/blogs/list");
        }
    }
}
