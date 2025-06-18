using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Skateboard3Server.Web.Services.Models.Common;
using Skateboard3Server.Web.Services.Models.SkateProfile;
using Skateboard3Server.Web.Storage;

namespace Skateboard3Server.Web.Services;

[Route("/skate3/ws/SkateProfile.asmx")]

[ApiController]
public class SkateProfileServiceController : ControllerBase
{
    private readonly IBlobStorage _blobStorage;
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    public SkateProfileServiceController(IBlobStorage blobStorage)
    {
        _blobStorage = blobStorage;
    }

    [HttpPost("StartLoginProcess")]
    [Consumes("application/x-www-form-urlencoded")]
    [Produces("text/xml")]
    public StartLoginProcessResponse StartLoginProcess([FromForm] StartLoginProcess data)
    {
        return new StartLoginProcessResponse
        {
            PrivacyFlagContainer = string.Empty, //TODO: forces a self-closing tag
            AwardedBoardSales = 0,
            TeamInfo = new TeamInfo //TODO
            {
                TeamId = 0,
                NumMembers = 0,
            }
        };
    }

    [HttpGet("GetSchema")]
    public async Task<IActionResult> GetSchema(PlatformType platformId, uint userId) //Note this is not authed on the real version
    {
        var objectKey = $"{platformId}/{userId}";
        if (!_blobStorage.ObjectExists("user-schema", objectKey))
        {
            return NotFound();
        }

        try
        {
            var bytes = await _blobStorage.GetObject("user-schema", objectKey);
            return File(bytes, "application/octet-stream");
        }
        catch (Exception e)
        {
            Logger.Warn(e);
            return NotFound();
        }
    }

    [HttpPost("UploadSchema")]
    [Consumes("multipart/form-data")]
    [Produces("text/xml")]
    public async Task<LongContainer> UploadSchema([FromForm] UploadSchema data)
    {
        if (data.Schema != null)
        {
            using (var stream = new MemoryStream()) //hack
            {
                await data.Schema.CopyToAsync(stream);
                await _blobStorage.PutObject("user-schema", $"{data.PlatformId}/{data.UserId}", stream.ToArray());
            }
            return new LongContainer(1); //TODO no idea if this number is right
        }
        return new LongContainer(0); //TODO no idea if this number is right
    }

    [HttpPost("UploadAIProfile")]
    [Consumes("multipart/form-data")]
    [Produces("text/xml")]
    public async Task<LongContainer> UploadAIProfile([FromForm] UploadAiProfile data)
	{
		if (data.AiProfile != null)
		{
			using (var stream = new MemoryStream()) //hack
			{
				await data.AiProfile.CopyToAsync(stream);
				await _blobStorage.PutObject("user-profile", $"{data.PlatformId}/{data.UserId}", stream.ToArray());
			}
			return new LongContainer(1); //TODO no idea if this number is right
		}
		return new LongContainer(0); //TODO no idea if this number is right
	}

    [HttpGet("GetAIProfile")]
	// [Consumes("application/x-www-form-urlencoded")]
	// [Produces("application/octet-stream")]
	public async Task<IActionResult> GetAIProfile(PlatformType platformId, uint userId)
	{
		var objectKey = $"{platformId}/{userId}";
		if (!_blobStorage.ObjectExists("user-profile", objectKey))
		{
			return NotFound();
		}

		try
		{
			var bytes = await _blobStorage.GetObject("user-profile", objectKey);
			return File(bytes, "application/octet-stream");
		}
		catch (Exception e)
		{
			Logger.Warn(e);
			return NotFound();
		}
	}

	[HttpPost("SetUserDLC")]
    [Consumes("application/x-www-form-urlencoded")]
    [Produces("text/xml")]
    public BoolContainer SetUserDlc([FromForm] SetUserDlc data)
    {
        return new BoolContainer(true);
    }

    [HttpPost("SetUserAchievements")]
    [Consumes("application/x-www-form-urlencoded")]
    [Produces("text/xml")]
    public IntegerContainer SetUserAchievements([FromForm] SetUserAchievements data)
    {
        return new IntegerContainer(0);
    }

    [HttpPost("Infect")]
    [Consumes("application/x-www-form-urlencoded")]
    [Produces("text/xml")]
    public BoolContainer Infect([FromForm] Infect data)
    {
        return new BoolContainer(false); // Not sure if it should be true or false
    }

    [HttpGet("GetUserLogos")]
    [Produces("text/xml")]
    public GetUserLogosResponse GetUserLogos([FromQuery] GetUserLogos data)
    {
        // seems to just return the userId
        return new GetUserLogosResponse
        {
            UserId = data.UserId
        };
    }

    [HttpPost("UploadThumbnail")]
    [Consumes("multipart/form-data")]
    [Produces("text/xml")]
    public LongContainer UploadThumbnail([FromForm] UploadThumbnail data)
    {
        return new LongContainer(0);
    }

    [HttpPost("AddAchievment")]
    [Consumes("application/x-www-form-urlencoded")]
    [Produces("text/xml")]
    public IntegerContainer AddAchievment([FromForm] AddAchievment data)
    {
        return new IntegerContainer(0);
    }

    [HttpGet("ShouldAwardCriticAchievement")]
    [Produces("text/xml")]
    public BoolContainer ShouldAwardCriticAchievement([FromQuery] ShouldAwardCriticAchievement data)
    {
        return new BoolContainer(false); // TODO: you need to rate a total of 5 skate parks, 5 films, and 5 photos to get this achievment
    }

    [HttpGet("ShouldAwardContributorAchievement")]
    [Produces("text/xml")]
    public BoolContainer ShouldAwardContributorAchievement([FromQuery] PlatformType PlatformId, uint UserId)
    {
        return new BoolContainer(false); // TODO: you need to Upload 5 Films and 5 Photos, and 3 skate.Parks to get this achievment
    }
}