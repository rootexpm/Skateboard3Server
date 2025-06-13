using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class GetSpaceUsed
{
    public PlatformType PlatformId { get; set; }
    public uint UserId {  get; set; }
}
