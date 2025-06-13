using System.Xml.Serialization;

namespace Skateboard3Server.Web.Services.Models.SkateProfile;

[XmlRoot("ProfileLogoInfo")]
public class GetUserLogosResponse
{
    [XmlElement("userId")]
    public uint UserId { get; set; }
}
