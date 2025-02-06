using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace FairRegistration;

[DependsOn(
    typeof(FairRegistrationApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class FairRegistrationHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(FairRegistrationApplicationContractsModule).Assembly,
            FairRegistrationRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FairRegistrationHttpApiClientModule>();
        });

    }
}
