using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class GetFeaturedContent
{
    public PlatformType PlatformId { get; set; }
    public int TypeId { get; set; }
    public int StartIndex { get; set; }
    public int EndIndex { get; set; }
}
