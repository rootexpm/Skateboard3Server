using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class GetFileContent
{
    public PlatformType PlatformId { get; set; }
    public uint FileId { get; set; }
    public uint UserId { get; set; } // Seems to be the LOCAL user id
    public uint ParkAuthorId { get; set; } = 0;
    public uint AuthorFileId { get; set; } = 0;
    public string Type { get; set; } = ".flv";
}
