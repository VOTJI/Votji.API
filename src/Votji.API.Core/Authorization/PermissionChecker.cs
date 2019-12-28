using Abp.Authorization;
using Votji.API.Authorization.Roles;
using Votji.API.Authorization.Users;

namespace Votji.API.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
