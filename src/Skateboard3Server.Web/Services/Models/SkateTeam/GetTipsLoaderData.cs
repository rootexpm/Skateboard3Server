using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateTeam;
public class GetTipsLoaderData
{
    public PlatformType PlatformType { get; set; }
    public uint UserId { get; set; }
    public uint LanguageType { get; set; } //TODO: enum?
}
