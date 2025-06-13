using System.Collections.Generic;
using System.Xml.Serialization;

namespace Skateboard3Server.Web.Services.Models.SkateReel;

[XmlRoot("ContentInfoContainer")]
public class GetFeaturedContentResponse
{
    [XmlElement("content")]
    public List<ContentInfo> Content { get; set; } = new List<ContentInfo>();
}