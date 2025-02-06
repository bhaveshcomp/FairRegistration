using FairRegistration.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FairRegistration.Permissions;

public class FairRegistrationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FairRegistrationPermissions.GroupName, L("Permission:FairRegistration"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FairRegistrationResource>(name);
    }
}
