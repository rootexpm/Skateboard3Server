using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Skateboard3Server.Web.Services.Models.SkateProfile;
using Skateboard3Server.Web.Services.Models.SkateTeam;
using Skateboard3Server.Web.Storage;

namespace Skateboard3Server.Web.Services;

[Route("/skate3/ws/SkateTeam.asmx")]
[ApiController]
public class SkateTeamServiceController : ControllerBase
{
    [HttpGet("GetTeamInfoByUserId")]
    [Produces("text/xml")]
    public TeamInfo GetTeamInfoByUserId([FromQuery] GetTeamInfoByUserId data)
    {
        // TODO: This should be in database, but for now we return a dummy value
        return new TeamInfo
        {
            TeamId = 0,
            NumMembers = 0,
        };
    }

    [HttpGet("GetTipsLoaderData")]
    [Produces("text/xml")]
    public GetTipsLoaderDataResponse GetTipsLoaderData([FromQuery] GetTipsLoaderData data)
    {
        var response = new GetTipsLoaderDataResponse();
        
        // Add sample feed item
        response.FeedItems.Items.Add(new FeedItem
        {
            Text = "#Randoms cramping your style? Create a private session or make it private through host actions."
        });
        
        // Add sample reel items (photos and skateparks)
        response.ReelItems.Items.AddRange(new[]
        {
            new ReelItem { Name = "#Juanpys", Value = "/skate3/content/PS3/PHOTO/0339/315731/293019.jpg" },
            new ReelItem { Name = "#jr_llps", Value = "/skate3/content/PS3/SKATEPARK/3533/7629/174661.bin" },
            new ReelItem { Name = "#MALiCE-MANKS", Value = "/skate3/content/PS3/PHOTO/3282/19666/292955.jpg" },
            new ReelItem { Name = "#NinjaChimp", Value = "/skate3/content/PS3/PHOTO/3284/7380/265229.jpg" },
            new ReelItem { Name = "#bergarn123", Value = "/skate3/content/PS3/PHOTO/2430/92542/332530.jpg" },
            new ReelItem { Name = "#vVgaVmanVv", Value = "/skate3/content/PS3/PHOTO/2632/199240/364139.jpg" },
            new ReelItem { Name = "#Xx-PuNk_RoCk-xX", Value = "/skate3/content/PS3/PHOTO/1328/185648/369008.jpg" },
            new ReelItem { Name = "#asherz-89", Value = "/skate3/content/PS3/SKATEPARK/0230/356582/331960.bin" },
            new ReelItem { Name = "#bizz_nitch321", Value = "/skate3/content/PS3/PHOTO/0898/41858/377354.jpg" },
            new ReelItem { Name = "#snkidsonly", Value = "/skate3/content/PS3/SKATEPARK/2402/6498/280416.bin" },
            new ReelItem { Name = "#uhhhson123", Value = "/skate3/content/PS3/SKATEPARK/3375/122159/90128.bin" },
            new ReelItem { Name = "#SaikoMantis", Value = "/skate3/content/PS3/PHOTO/3567/19951/161782.jpg" },
            new ReelItem { Name = "#cheesewiz04", Value = "/skate3/content/PS3/SKATEPARK/1770/75498/89019.bin" },
            new ReelItem { Name = "#efe13PS", Value = "/skate3/content/PS3/SKATEPARK/0299/139563/276691.bin" },
            new ReelItem { Name = "#sebbe_1996", Value = "/skate3/content/PS3/PHOTO/0889/267129/278052.jpg" },
            new ReelItem { Name = "#foxy205", Value = "/skate3/content/PS3/PHOTO/1535/177663/222341.jpg" }
        });
        
        return response;
    }
}
