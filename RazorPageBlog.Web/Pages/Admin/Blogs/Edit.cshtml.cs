using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageBlog.Web.Data;
using RazorPageBlog.Web.Models.Domain;

namespace RazorPageBlog.Web.Pages.Admin.Blogs
{
    public class EditModel : PageModel
    {
        private readonly BlogDbContext _blogDbContext;

        [BindProperty]
        public BlogPost BlogPost { get; set; }
        public EditModel(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }
        public void OnGet(Guid id)
        {
            BlogPost = _blogDbContext.BlogPosts.Find(id);

        }

        public IActionResult OnPostEdit()
        {
            var existingBlogPost = _blogDbContext.BlogPosts.Find(BlogPost.Id);

            if (existingBlogPost != null)
            {
                existingBlogPost.Heading = BlogPost.Heading;
                existingBlogPost.PageTitle = BlogPost.PageTitle;
                existingBlogPost.Content = BlogPost.Content;
                existingBlogPost.ShortDescription = BlogPost.ShortDescription;
                existingBlogPost.FeatureImageUrl = BlogPost.FeatureImageUrl;
                existingBlogPost.UrlHandle = BlogPost.UrlHandle;
                existingBlogPost.PublishedDate = BlogPost.PublishedDate;
                existingBlogPost.Author = BlogPost.Author;
                existingBlogPost.Visible = BlogPost.Visible;

                _blogDbContext.SaveChanges();
            }
            return RedirectToPage("/admin/blogs/list");
        }

        public IActionResult OnPostDelete()
        {
            var existingBlogPost = _blogDbContext.BlogPosts.Find(BlogPost.Id);

            if (existingBlogPost != null)
            {
                _blogDbContext.BlogPosts.Remove(existingBlogPost);
                _blogDbContext.SaveChanges();
                return RedirectToPage("/admin/blogs/list");
            }

            return Page();
        }
    }
}
