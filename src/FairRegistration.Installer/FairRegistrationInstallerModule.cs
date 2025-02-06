using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace FairRegistration;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class FairRegistrationInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FairRegistrationInstallerModule>();
        });
    }
}
