using Skateboard3Server.Web.Services.Models.Common;
using System.Collections.Generic;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class Upload
{
    public PlatformType PlatformId { get; set; }
    public uint UserId { get; set; }
    public int TypeId  { get; set; }
    public int LocationId { get; set; }
    public uint AuthorId { get; set; }
    public uint AuthorFileId { get; set; }
    public required string Tags { get; set; }
    public uint OnlineId { get; set; }
    public required string Description { get; set; }
    public required string Thumbnail {  get; set; } // JFIF thumbnail
    public required string File {  get; set; } // Could be JFIF or FLV (assumption)
}
