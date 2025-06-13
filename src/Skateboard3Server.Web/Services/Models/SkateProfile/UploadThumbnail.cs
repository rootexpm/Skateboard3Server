using Microsoft.AspNetCore.Http;
using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateProfile;
public class UploadThumbnail
{
    public PlatformType PlatformId { get; set; }
    public uint UserId { get; set; }
    public int TypeId { get; set; } //TODO: enum?
    public IFormFile? Image {  get; set; } // seems to be a JFIF file (magic: FF D8 FF E0 00 10 4A 46 49 46 00 01)
}
