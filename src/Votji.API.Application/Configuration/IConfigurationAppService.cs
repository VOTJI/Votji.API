using System.Threading.Tasks;
using Votji.API.Configuration.Dto;

namespace Votji.API.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
