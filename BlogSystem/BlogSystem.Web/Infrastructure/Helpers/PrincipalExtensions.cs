using BlogSystem.Common;
using System.Security.Principal;

namespace BlogSystem.Web.Infrastructure.Helpers
{
    public static class PrincipalExtensions
    {
        public static bool IsLoggedIn(this IPrincipal principal)
        {
            return principal.Identity.IsAuthenticated;
        }

        public static bool IsAdmin(this IPrincipal principal)
        {
            return principal.IsInRole(Constants.AdministratorRoleName);
        }
    }
}
