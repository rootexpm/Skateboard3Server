using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateProfile;
public class AddAchievment
{
    public PlatformType PlatformId { get; set; }
    public uint UserId { get; set; }
    public uint AchievmentId { get; set; }
}
