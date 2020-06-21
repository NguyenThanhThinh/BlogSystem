using System;
using BlogSystem.Models;
using BlogSystem.Web.Infrastructure.Mapping;

namespace BlogSystem.Web.ViewModels.Blog
{
    public class BlogPostViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Content { get; set; }

        public string MetaDescription { get; set; }

        public string MetaKeywords { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}