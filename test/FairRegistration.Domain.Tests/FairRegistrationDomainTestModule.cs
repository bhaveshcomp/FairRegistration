using Volo.Abp.Modularity;

namespace FairRegistration;

[DependsOn(
    typeof(FairRegistrationDomainModule),
    typeof(FairRegistrationTestBaseModule)
)]
public class FairRegistrationDomainTestModule : AbpModule
{

}
