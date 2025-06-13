using System.Collections.Generic;
using System.Xml.Serialization;

namespace Skateboard3Server.Web.Services.Models.SkateReel;

[XmlRoot("TagsContainer")]
public class GetCategoriesAndTagsResponse
{
    [XmlElement("categories")]
    public List<Category> Categories { get; set; } = new List<Category>();
}

public class Category
{
    [XmlElement("categoryId")]
    public int CategoryId { get; set; }
    
    [XmlElement("language")]
    public int Language { get; set; }
    
    [XmlElement("name")]
    public string Name { get; set; } = string.Empty;
    
    [XmlElement("tags")]
    public List<Tag> Tags { get; set; } = new List<Tag>();
}

public class Tag
{
    [XmlElement("tagId")]
    public int TagId { get; set; }
    
    [XmlElement("categoryId")]
    public int CategoryId { get; set; }
    
    [XmlElement("language")]
    public int Language { get; set; }
    
    [XmlElement("name")]
    public string Name { get; set; } = string.Empty;
}