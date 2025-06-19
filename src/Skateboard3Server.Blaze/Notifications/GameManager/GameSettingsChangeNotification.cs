using System.Collections.Generic;
using Skateboard3Server.Blaze.Common;
using Skateboard3Server.Blaze.Serializer.Attributes;
using Skateboard3Server.Blaze.Server;

#pragma warning disable CS8618

namespace Skateboard3Server.Blaze.Notifications.GameManager;

[BlazeNotification(BlazeComponent.GameManager, (ushort)GameManagerNotification.GameSettingsChange)]
public record GameSettingsChangeNotification : BlazeNotificationMessage
{
	[TdfField("ATTR")]
	public uint GameSettings { get; init; }

	[TdfField("GID")]
	public uint GameId { get; init; }
}

