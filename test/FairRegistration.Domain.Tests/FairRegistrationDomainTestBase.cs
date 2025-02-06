using Volo.Abp.Modularity;

namespace FairRegistration;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class FairRegistrationDomainTestBase<TStartupModule> : FairRegistrationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
