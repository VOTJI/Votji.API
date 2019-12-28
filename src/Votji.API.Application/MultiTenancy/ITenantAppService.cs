using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Votji.API.MultiTenancy.Dto;

namespace Votji.API.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

