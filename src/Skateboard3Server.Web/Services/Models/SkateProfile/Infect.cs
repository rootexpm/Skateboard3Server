using Skateboard3Server.Web.Services.Models.Common;

namespace Skateboard3Server.Web.Services.Models.SkateProfile
{
    public class Infect
    {
        public PlatformType PlatformId { get; set; }
        public uint UserIds { get; set; } // Probably array
    }
}
