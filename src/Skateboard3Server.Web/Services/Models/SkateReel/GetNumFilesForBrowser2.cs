using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class GetNumFilesForBrowser2
{
    public PlatformType PlatformId { get; set; }
    public int TypeId { get; set; } //TODO: enum
    public int User { get; set; }
    public int LookupType { get; set; }
    public uint LocalUserId { get; set; }
}
