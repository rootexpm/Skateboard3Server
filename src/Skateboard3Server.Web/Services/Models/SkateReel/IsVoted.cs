using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class IsVoted
{
    public PlatformType PlatformId { get; set; }
    public uint FileId { get; set; }
    public uint ReviewerUserId { get; set; } // local user id
}
