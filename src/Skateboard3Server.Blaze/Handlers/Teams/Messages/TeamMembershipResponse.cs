using Skateboard3Server.Blaze.Handlers.Social.Messages;
using Skateboard3Server.Blaze.Serializer.Attributes;
using Skateboard3Server.Blaze.Server;
using System.Collections.Generic;

namespace Skateboard3Server.Blaze.Handlers.Teams.Messages;

[BlazeResponse(BlazeComponent.Teams, (ushort)TeamsCommand.TeamMembership)]
public record TeamMembershipResponse : BlazeResponseMessage
{
	//responds empty if ur not in a team? TODO: check if dis true

	[TdfField("MMAP")]
	public Dictionary<uint, PlayerEntry>? TeamPlayers { get; init; } //TODO: Name format?
}

public record PlayerEntry
{
	[TdfField("CLID")]
	public uint ClientId { get; init; }

	[TdfField("MBER")]
	public Member Member { get; init; }

	[TdfField("NAME")]
	public string TeamName { get; init; }
}

public record Member
{
	[TdfField("BLID")]
	public uint BlazeId { get; init; } 

	[TdfField("CMTP")]
	public int CMTP { get; init; } //TODO: Name

	[TdfField("MBOS")]
	public int MBOS { get; init; } //TODO: Name

	[TdfField("MSTM")]
	public uint MSTM { get; init; } //TODO: Name

	[TdfField("PERS")]
	public string PersonaName { get; init; }
}