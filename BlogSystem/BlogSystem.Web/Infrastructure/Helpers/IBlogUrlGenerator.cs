using System;

namespace BlogSystem.Web.Infrastructure.Helpers
{
    public interface IBlogUrlGenerator
    {
        string GenerateUrl(int id, string title, DateTime createdOn);
    }
}
