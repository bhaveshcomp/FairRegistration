using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace FairRegistration;

[DependsOn(
    typeof(FairRegistrationDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class FairRegistrationApplicationContractsModule : AbpModule
{

}
