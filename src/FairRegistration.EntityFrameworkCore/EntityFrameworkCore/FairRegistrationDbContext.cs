using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace FairRegistration.EntityFrameworkCore;

[ConnectionStringName(FairRegistrationDbProperties.ConnectionStringName)]
public class FairRegistrationDbContext : AbpDbContext<FairRegistrationDbContext>, IFairRegistrationDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public FairRegistrationDbContext(DbContextOptions<FairRegistrationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureFairRegistration();
    }
}
