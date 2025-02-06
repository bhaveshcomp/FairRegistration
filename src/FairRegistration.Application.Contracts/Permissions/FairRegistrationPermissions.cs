using Volo.Abp.Reflection;

namespace FairRegistration.Permissions;

public class FairRegistrationPermissions
{
    public const string GroupName = "FairRegistration";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(FairRegistrationPermissions));
    }
}
