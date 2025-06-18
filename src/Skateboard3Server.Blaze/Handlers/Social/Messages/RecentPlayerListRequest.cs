using System.Collections.Generic;
using JetBrains.Annotations;
using MediatR;
using Skateboard3Server.Blaze.Serializer.Attributes;
using Skateboard3Server.Blaze.Server;

#pragma warning disable CS8618

namespace Skateboard3Server.Blaze.Handlers.Social.Messages;

[BlazeRequest(BlazeComponent.Social, (ushort)SocialCommand.RecentPlayerList)]
[UsedImplicitly]
public record RecentPlayerListRequest : BlazeRequestMessage, IRequest<RecentPlayerListResponse>
{
	[TdfField("ALNM")]
	public string RecentPlayerList { get; init; } //TODO: Name

	[TdfField("BIDL")]
	public List<BIDL> PlayerList { get; init; } //TODO: Name (I think)
}

public record BIDL //TODO: Name
{
	[TdfField("BLID")]
	public uint ID { get; init; } //TODO: Name

	[TdfField("ETID")]
	public ETID ETID { get; init; } //TODO: Name
}

public record ETID //TODO: Name
{
	[TdfField("EID")]
	public string EID { get; init; }//TODO: Name

	[TdfField("PNM")]
	public string Username { get; init; } 
}