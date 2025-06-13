using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateFeed;
public class PlayerStartedOnlineFreeskate2
{
    public PlatformType PlatformId { get; set; }
    public uint UserId { get; set; }
    public string ChallengeName { get; set; } = string.Empty;
    public bool IsHost { get; set; }
}
