using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace FairRegistration;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(FairRegistrationDomainSharedModule)
)]
public class FairRegistrationDomainModule : AbpModule
{

}
