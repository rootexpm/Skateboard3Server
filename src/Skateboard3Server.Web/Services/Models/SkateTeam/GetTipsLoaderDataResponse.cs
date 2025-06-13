using System.Collections.Generic;
using System.Xml.Serialization;

namespace Skateboard3Server.Web.Services.Models.SkateTeam;

[XmlRoot("TipsLoaderData")]
public class GetTipsLoaderDataResponse
{
    [XmlElement("stats")]
    public Stats Stats { get; set; } = new Stats();
    
    [XmlElement("leaderboard")]
    public Leaderboard Leaderboard { get; set; } = new Leaderboard();
    
    [XmlElement("feedItems")]
    public FeedItems FeedItems { get; set; } = new FeedItems();
    
    [XmlElement("reelItems")]
    public ReelItems ReelItems { get; set; } = new ReelItems();
}

public class Stats
{
    // Empty stats element
}

public class Leaderboard
{
    [XmlElement("centred")]
    public bool Centred { get; set; } = false;
}

public class FeedItems
{
    [XmlElement("items")]
    public List<FeedItem> Items { get; set; } = new List<FeedItem>();
}

public class FeedItem
{
    [XmlElement("text")]
    public string Text { get; set; } = string.Empty;
}

public class ReelItems
{
    [XmlElement("items")]
    public List<ReelItem> Items { get; set; } = new List<ReelItem>();
}

public class ReelItem
{
    [XmlElement("name")]
    public string Name { get; set; } = string.Empty;
    
    [XmlElement("value")]
    public string Value { get; set; } = string.Empty;
}
