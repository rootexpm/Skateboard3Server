using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class Vote
{
    public PlatformType PlatformId { get; set; }
    public uint FileId { get; set; }
    public uint ReviewerUserId { get; set; }
    public float Rating { get; set; }
    public int NeedTotalVoteCount { get; set; }
}
