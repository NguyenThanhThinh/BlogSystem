using System;
using BlogSystem.Models;
using BlogSystem.Web.Infrastructure.Mapping;

namespace BlogSystem.Web.ViewModels.Pages
{
    public class PageViewModel : IMapFrom<Page>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime LastModified { get; set; }
    }
}