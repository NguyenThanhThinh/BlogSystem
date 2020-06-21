namespace BlogSystem.Web.ViewModels
{
    using System;
    using BlogSystem.Models;
    using BlogSystem.Models.Enums;
    using BlogSystem.Web.Infrastructure.Mapping;
    using Infrastructure.Helpers;

    public class RecentBlogPostViewModel : IMapFrom<Post>
    {
        private readonly IBlogUrlGenerator urlGenerator;

        public RecentBlogPostViewModel()
            : this(new BlogUrlGenerator())
        {
        }

        public RecentBlogPostViewModel(IBlogUrlGenerator urlGenerator)
        {
            this.urlGenerator = urlGenerator;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public PostType Type { get; set; }

        public DateTime CreatedOn { get; set; }

        public string IconClass
        {
            get
            {
                if (this.Type == PostType.Video)
                {
                    return "fa-youtube-play";
                }
                else
                {
                    return "fa-file-text";
                }
            }
        }

        public string Url
        {
            get
            {
                return this.urlGenerator.GenerateUrl(this.Id, this.Title, this.CreatedOn);
            }
        }
    }
}