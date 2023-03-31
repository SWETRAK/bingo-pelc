namespace BingoPelc.Configs;

public class AuthenticationSettings
{
    public string JwtKey { get; set; }
    public UInt16 JwtExpireDays { get; set; }
    public string JwtIssuer { get; set; }
}