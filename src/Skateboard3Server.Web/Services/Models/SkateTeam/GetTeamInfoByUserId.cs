using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateTeam;
public class GetTeamInfoByUserId
{
    public PlatformType PlatformType { get; set; }
    public uint UserId { get; set; }
}
