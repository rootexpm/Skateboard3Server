using System.Xml.Serialization;

namespace Skateboard3Server.Web.Services.Models.SkateReel;
public class ContentInfo
{
    [XmlElement("fileId")]
    public int FileId { get; set; }

    [XmlElement("fileType")]
    public string FileType { get; set; } = string.Empty;

    [XmlElement("ownerId")]
    public int OwnerId { get; set; }

    [XmlElement("ownerName")]
    public string OwnerName { get; set; } = string.Empty;

    [XmlElement("locationId")]
    public long LocationId { get; set; }

    [XmlElement("downloadCount")]
    public int DownloadCount { get; set; }

    [XmlElement("voteCount")]
    public int VoteCount { get; set; }

    [XmlElement("rating")]
    public float Rating { get; set; }

    [XmlElement("rank")]
    public int Rank { get; set; }

    [XmlElement("rankType")]
    public string RankType { get; set; } = string.Empty;

    [XmlElement("fileSize")]
    public int FileSize { get; set; }

    [XmlElement("tag1")]
    public int Tag1 { get; set; }

    [XmlElement("tag2")]
    public int Tag2 { get; set; }

    [XmlElement("tag3")]
    public int Tag3 { get; set; }

    [XmlElement("tag4")]
    public int Tag4 { get; set; }

    [XmlElement("tag5")]
    public int Tag5 { get; set; }

    [XmlElement("contentUri")]
    public string ContentUri { get; set; } = string.Empty;

    [XmlElement("thumbnailUri")]
    public string ThumbnailUri { get; set; } = string.Empty;

    [XmlElement("createDate")]
    public long CreateDate { get; set; }

    [XmlElement("teamName")]
    public string TeamName { get; set; } = string.Empty;

    [XmlElement("description")]
    public string Description { get; set; } = string.Empty;

    [XmlElement("authorId")]
    public int AuthorId { get; set; }

    [XmlElement("authorName")]
    public string AuthorName { get; set; } = string.Empty;

    [XmlElement("authorFileId")]
    public int AuthorFileId { get; set; }
}
