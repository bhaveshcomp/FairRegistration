using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace FairRegistration;

[DependsOn(
    typeof(FairRegistrationDomainModule),
    typeof(FairRegistrationApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class FairRegistrationApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<FairRegistrationApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<FairRegistrationApplicationModule>(validate: true);
        });
    }
}
