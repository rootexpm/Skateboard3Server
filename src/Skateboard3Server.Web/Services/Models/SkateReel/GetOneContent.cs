using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class GetOneContent
{
    public PlatformType PlatformId { get; set; }
    public uint FileId { get; set; }
}
