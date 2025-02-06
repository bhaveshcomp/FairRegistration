using Volo.Abp.Modularity;

namespace FairRegistration;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class FairRegistrationApplicationTestBase<TStartupModule> : FairRegistrationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
