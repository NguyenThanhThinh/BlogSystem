namespace BlogSystem.Web.ViewModels.Home
{
    using System;

    using AutoMapper;
    using BlogSystem.Models;
    using BlogSystem.Web.Infrastructure.Mapping;
    using Infrastructure.Helpers;

    public class BlogPostAnnotationViewModel : IMapFrom<Post>, IHaveCustomMappings
    {
        private readonly IBlogUrlGenerator urlGenerator;

        public BlogPostAnnotationViewModel()
            : this(new BlogUrlGenerator())
        {
        }

        public BlogPostAnnotationViewModel(IBlogUrlGenerator urlGenerator)
        {
            this.urlGenerator = urlGenerator;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ImageOrVideoUrl { get; set; }

        public string Url => this.urlGenerator.GenerateUrl(this.Id, this.Title, this.CreatedOn);

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Post, BlogPostAnnotationViewModel>()
                .ForMember(m => m.Content, opt => opt.MapFrom(u => u.ShortContent));
        }
    }
}