using Localization.Resources.AbpUi;
using FairRegistration.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace FairRegistration;

[DependsOn(
    typeof(FairRegistrationApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class FairRegistrationHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(FairRegistrationHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<FairRegistrationResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
