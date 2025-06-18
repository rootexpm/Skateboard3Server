using System.Collections.Generic;
using Skateboard3Server.Blaze.Common;
using Skateboard3Server.Blaze.Serializer.Attributes;
using Skateboard3Server.Blaze.Server;

#pragma warning disable CS8618

namespace Skateboard3Server.Blaze.Handlers.Social.Messages;

[BlazeResponse(BlazeComponent.Social, (ushort)SocialCommand.RecentPlayerList)]
public record RecentPlayerListResponse : BlazeResponseMessage
{
	[TdfField("BIDL")]
	public List<ListData>? BidlSessions { get; init; }//TODO: Name? (userList?)

	[TdfField("RBDL")]
	public List<ListData>? RbdlSessions { get; init; }//TODO: Name? (userList?)
}

