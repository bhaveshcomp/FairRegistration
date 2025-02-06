using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace FairRegistration.EntityFrameworkCore;

[ConnectionStringName(FairRegistrationDbProperties.ConnectionStringName)]
public interface IFairRegistrationDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
