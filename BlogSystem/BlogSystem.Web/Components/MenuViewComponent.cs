using System.Threading.Tasks;
using AutoMapper;
using BlogSystem.Common;
using BlogSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogSystem.Web.ViewModels.Home;

namespace BlogSystem.Web.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IDeletableEntityRepository<Page> pagesData;
        private readonly IMapper mapper;

        public MenuViewComponent(
            IDeletableEntityRepository<Page> pagesData, 
            IMapper mapper)
        {
            this.pagesData = pagesData;
            this.mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menuItems = await this.mapper
                .ProjectTo<MenuItemViewModel>(this.pagesData.All())
                .ToListAsync();

            return this.View("Menu", menuItems);
        }
    }
}
