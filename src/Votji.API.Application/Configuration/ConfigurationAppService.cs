using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Votji.API.Configuration.Dto;

namespace Votji.API.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : APIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
