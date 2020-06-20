using AutoMapper;

namespace BlogSystem.Web.Infrastructure.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(Profile configuration);
    }
}
