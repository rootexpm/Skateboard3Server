using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class GetCategoriesAndTags
{
    public PlatformType PlatformId { get; set; }
    public uint LanguageType { get; set; } // TODO: enum
    public int TypeId { get; set; } //TODO: enum
}
