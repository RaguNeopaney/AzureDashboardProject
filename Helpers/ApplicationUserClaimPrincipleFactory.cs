using Dashboard.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Dashboard.Helpers
{
    public class ApplicationUserClaimPrincipleFactory : UserClaimsPrincipalFactory<DashboardUser>
    {
        public ApplicationUserClaimPrincipleFactory(UserManager<DashboardUser> userManager, IOptions<IdentityOptions> options) : base(userManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(DashboardUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("UserFirstName", user.FirstName ?? ""));
            identity.AddClaim(new Claim("UserLastName", user.LastName ?? ""));
            return identity;
        }
    }
}