using FairRegistration.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FairRegistration;

public abstract class FairRegistrationController : AbpControllerBase
{
    protected FairRegistrationController()
    {
        LocalizationResource = typeof(FairRegistrationResource);
    }
}
