using System.Xml.Serialization;

namespace Skateboard3Server.Web.Services.Models.SkateReel;

[XmlRoot("VoteInfo")]
public class VoteInfo
{
    [XmlElement("isVoted")]
    public int IsVoted { get; set; }

    [XmlElement("totalVoteCount")]
    public int TotalVoteCount { get; set; } // TODO: is this optional?
}
