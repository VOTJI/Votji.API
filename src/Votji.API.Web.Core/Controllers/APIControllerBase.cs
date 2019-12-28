using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Votji.API.Controllers
{
    public abstract class APIControllerBase: AbpController
    {
        protected APIControllerBase()
        {
            LocalizationSourceName = APIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
