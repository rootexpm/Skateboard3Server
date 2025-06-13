using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class AddBookmark
{
    public PlatformType PlatformId { get; set; }
    public uint UserId { get; set; }
    public uint FileId { get; set; }
    public int Type { get; set; }
    public uint CreatorId { get; set; }
    public required string CreatorName { get; set; }
}
