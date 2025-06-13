using Microsoft.AspNetCore.Mvc;
using Skateboard3Server.Web.Services.Models.Common;
using Skateboard3Server.Web.Services.Models.SkateReel;

namespace Skateboard3Server.Web.Services;

[Route("/skate3/ws/SkateReel.asmx")]
[ApiController]
public class SkateReelServiceController : ControllerBase
{
    [HttpGet("GetCategoriesAndTags")]
    [Produces("text/xml")]
    public GetCategoriesAndTagsResponse GetCategoriesAndTags([FromQuery] GetCategoriesAndTags data)
    {
        var response = new GetCategoriesAndTagsResponse();
        
        // Style category
        var styleCategory = new Category
        {
            CategoryId = 1,
            Language = 0,
            Name = "Style"
        };
        
        styleCategory.Tags.AddRange(new[]
        {
            new Tag { TagId = 1, CategoryId = 1, Language = 0, Name = "Realistic" },
            new Tag { TagId = 2, CategoryId = 1, Language = 0, Name = "Arcade" },
            new Tag { TagId = 3, CategoryId = 1, Language = 0, Name = "Hall of Meat" },
            new Tag { TagId = 4, CategoryId = 1, Language = 0, Name = "Flatland" },
            new Tag { TagId = 5, CategoryId = 1, Language = 0, Name = "Vert" },
            new Tag { TagId = 6, CategoryId = 1, Language = 0, Name = "Funny" },
            new Tag { TagId = 7, CategoryId = 1, Language = 0, Name = "Co-op" },
            new Tag { TagId = 8, CategoryId = 1, Language = 0, Name = "Story" },
            new Tag { TagId = 9, CategoryId = 1, Language = 0, Name = "Online" },
            new Tag { TagId = 10, CategoryId = 1, Language = 0, Name = "Style" },
            new Tag { TagId = 11, CategoryId = 1, Language = 0, Name = "Hard" },
            new Tag { TagId = 12, CategoryId = 1, Language = 0, Name = "Found" },
            new Tag { TagId = 13, CategoryId = 1, Language = 0, Name = "Career" },
            new Tag { TagId = 14, CategoryId = 1, Language = 0, Name = "Wacky" }
        });
        
        // Type category
        var typeCategory = new Category
        {
            CategoryId = 2,
            Language = 0,
            Name = "Type"
        };
        
        typeCategory.Tags.AddRange(new[]
        {
            new Tag { TagId = 1, CategoryId = 2, Language = 0, Name = "Location" },
            new Tag { TagId = 2, CategoryId = 2, Language = 0, Name = "Grind" },
            new Tag { TagId = 3, CategoryId = 2, Language = 0, Name = "Gap" },
            new Tag { TagId = 4, CategoryId = 2, Language = 0, Name = "Flip Trick" },
            new Tag { TagId = 5, CategoryId = 2, Language = 0, Name = "Air" },
            new Tag { TagId = 6, CategoryId = 2, Language = 0, Name = "Grab" },
            new Tag { TagId = 7, CategoryId = 2, Language = 0, Name = "Line" },
            new Tag { TagId = 8, CategoryId = 2, Language = 0, Name = "Manual" },
            new Tag { TagId = 9, CategoryId = 2, Language = 0, Name = "Bail" },
            new Tag { TagId = 10, CategoryId = 2, Language = 0, Name = "Accident" },
            new Tag { TagId = 11, CategoryId = 2, Language = 0, Name = "Mayhem" },
            new Tag { TagId = 12, CategoryId = 2, Language = 0, Name = "Peds" },
            new Tag { TagId = 13, CategoryId = 2, Language = 0, Name = "Cars" },
            new Tag { TagId = 14, CategoryId = 2, Language = 0, Name = "Props" },
            new Tag { TagId = 15, CategoryId = 2, Language = 0, Name = "Home Brew" },
            new Tag { TagId = 16, CategoryId = 2, Language = 0, Name = "Alley" },
            new Tag { TagId = 17, CategoryId = 2, Language = 0, Name = "Bowl" },
            new Tag { TagId = 18, CategoryId = 2, Language = 0, Name = "Fun Box" },
            new Tag { TagId = 19, CategoryId = 2, Language = 0, Name = "Stair Set" },
            new Tag { TagId = 20, CategoryId = 2, Language = 0, Name = "Manny Pad" }
        });
        
        // High Resolution category
        var highResCategory = new Category
        {
            CategoryId = 3,
            Language = 0,
            Name = "High Resolution"
        };
        
        highResCategory.Tags.AddRange(new[]
        {
            new Tag { TagId = 1, CategoryId = 3, Language = 0, Name = "No" },
            new Tag { TagId = 2, CategoryId = 3, Language = 0, Name = "Yes" }
        });
        
        response.Categories.Add(styleCategory);
        response.Categories.Add(typeCategory);
        response.Categories.Add(highResCategory);
        
        return response;
    }

    [HttpGet("GetSpaceUsed")]
    [Produces("text/xml")]
    public LongContainer GetSpaceUsed([FromQuery] GetSpaceUsed data)
    {
        return new LongContainer(0); // TODO: find out what it should actually return (i think it returns 1 if the user has uploaded the max amount of photos/videos allowed)
    }

    [HttpGet("GetNumFilesForBrowser2")]
    [Produces("text/xml")]
    public IntegerContainer GetNumFilesForBrowser2([FromQuery] GetNumFilesForBrowser2 data)
    {
        return new IntegerContainer(0); // TODO: this is the number of files the user uploaded
    }

    [HttpGet("GetFeaturedContent")]
    [Produces("text/xml")]
    public GetFeaturedContentResponse GetFeaturedContent([FromQuery] GetFeaturedContent data)
    {
        return new GetFeaturedContentResponse(); // TODO: actually populate the response
    }

    [HttpGet("IsVoted")]
    [Produces("text/xml")]
    public IntegerContainer IsVoted([FromQuery] IsVoted data)
    {
        return new IntegerContainer(0); // TODO: this is based off if you rated the video or not
    }

    [HttpGet("GetOneContent")]
    [Produces("text/xml")]
    public ContentInfo GetOneContent([FromQuery] GetOneContent data)
    {
        return new ContentInfo();
    }

    [HttpGet("GetFileContent")]
    [Produces("video/x-flv")] // TODO: should we only return FLV's?
    public IntegerContainer GetFileContent([FromQuery] GetFileContent data)
    {
        return new IntegerContainer(0); // TODO: just return the FLV file
    }

    [HttpPost("AddBookmark")]
    [Produces("text/html")]
    public IntegerContainer AddBookmark([FromForm] AddBookmark data)
    {
        return new IntegerContainer(1); // 1 is succcess, 2 is when you try to bookmark a file you already bookmarked, and i assume 0 is failure
    }

    [HttpPost("Vote")]
    [Produces("text/html")]
    public VoteInfo Vote([FromForm] Vote data)
    {
        return new VoteInfo();
    }

    [HttpPost("Upload")]
    [Consumes("multipart/form-data")]
    [Produces("text/html")]
    public LongContainer Upload([FromForm] Upload data)
    {
        return new LongContainer(0); // TODO: return the file id
    }
}
