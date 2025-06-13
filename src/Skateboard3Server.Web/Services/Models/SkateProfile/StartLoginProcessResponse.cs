using System.Xml.Serialization;

#pragma warning disable CS8618

namespace Skateboard3Server.Web.Services.Models.SkateProfile;

[XmlRoot(ElementName = "LoginInfoContainer")]
public class StartLoginProcessResponse
{

    [XmlElement(ElementName = "privacyFlagContainer")]
    public string PrivacyFlagContainer { get; set; } //TODO: string probably isnt right, but need it to force a selfclosing tag

    [XmlElement(ElementName = "awardedBoardSales")]
    public ulong AwardedBoardSales { get; set; }

    [XmlElement(ElementName = "teamInfo")]
    public TeamInfo TeamInfo { get; set; }
}

[XmlRoot(ElementName = "logo")]
public class Logo
{
    public int IteamId { get; set; }
    public string Uri { get; set; }
    public string RtexUri { get; set; } // seems to be same as uri
}

public class TeamInfo
{
    [XmlElement(ElementName = "teamId")]
    public uint TeamId { get; set; } //TODO: long correct type?

    [XmlElement(ElementName = "numMembers")]
    public uint NumMembers { get; set; } //TODO: long correct type?

    [XmlElement(ElementName = "teamName")]
    public string? TeamName { get; set; }

    Logo? logo { get; set; }
}