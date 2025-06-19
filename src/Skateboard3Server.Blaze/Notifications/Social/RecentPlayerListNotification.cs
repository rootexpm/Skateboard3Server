using Skateboard3Server.Blaze.Common;
using Skateboard3Server.Blaze.Handlers.Social.Messages;
using Skateboard3Server.Blaze.Serializer.Attributes;
using Skateboard3Server.Blaze.Server;
using System.Collections.Generic;

#pragma warning disable CS8618

namespace Skateboard3Server.Blaze.Notifications.UserSession;

[BlazeNotification(BlazeComponent.Social, (ushort)SocialNotification.RecentPlayerList)]
public record RecentPlayerListNotification : BlazeNotificationMessage
{
	[TdfField("ALML")]
	public List<ResponseList>? UserList { get; set; } //user list?
}