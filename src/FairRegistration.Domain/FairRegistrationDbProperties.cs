namespace FairRegistration;

public static class FairRegistrationDbProperties
{
    public static string DbTablePrefix { get; set; } = "FairRegistration";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "FairRegistration";
}
