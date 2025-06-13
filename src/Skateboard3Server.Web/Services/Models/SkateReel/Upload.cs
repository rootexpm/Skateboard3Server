using Microsoft.AspNetCore.Http;
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
    public int AuthorFileId { get; set; }
    public string? Tags { get; set; }
    public uint OnlineId { get; set; }
    public string? Description { get; set; }
    public IFormFile? Thumbnail {  get; set; } // JFIF thumbnail
    public IFormFile? File { get; set; } // Could be JFIF or FLV (assumption)
}
