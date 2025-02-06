using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FairRegistration.EntityFrameworkCore;

[DependsOn(
    typeof(FairRegistrationDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class FairRegistrationEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<FairRegistrationDbContext>(options =>
        {
            options.AddDefaultRepositories(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
