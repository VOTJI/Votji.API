using System.Threading.Tasks;
using Abp.Application.Services;
using Votji.API.Sessions.Dto;

namespace Votji.API.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
