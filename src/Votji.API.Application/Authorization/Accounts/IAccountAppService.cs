using System.Threading.Tasks;
using Abp.Application.Services;
using Votji.API.Authorization.Accounts.Dto;

namespace Votji.API.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
