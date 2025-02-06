using Volo.Abp.Modularity;

namespace FairRegistration;

[DependsOn(
    typeof(FairRegistrationApplicationModule),
    typeof(FairRegistrationDomainTestModule)
    )]
public class FairRegistrationApplicationTestModule : AbpModule
{

}
