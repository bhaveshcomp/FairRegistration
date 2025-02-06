using FairRegistration.Localization;
using Volo.Abp.Application.Services;

namespace FairRegistration;

public abstract class FairRegistrationAppService : ApplicationService
{
    protected FairRegistrationAppService()
    {
        LocalizationResource = typeof(FairRegistrationResource);
        ObjectMapperContext = typeof(FairRegistrationApplicationModule);
    }
}
