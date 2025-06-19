using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skateboard3Server.Blaze.Handlers.Social.Messages;
using Skateboard3Server.Blaze.Notifications.SkateStats;
using Skateboard3Server.Blaze.Notifications.UserSession;
using Skateboard3Server.Blaze.Server;

namespace Skateboard3Server.Blaze.Handlers.Social;

public class RecentFriendsListHandler : IRequestHandler<RecentPlayerListRequest, RecentPlayerListResponse>
{
	private readonly IBlazeNotificationHandler _notificationHandler;

	public RecentFriendsListHandler(IBlazeNotificationHandler notificationHandler)
	{
		_notificationHandler = notificationHandler;
	}

	public async Task<RecentPlayerListResponse> Handle(RecentPlayerListRequest request, CancellationToken cancellationToken)
	{
		var response = new RecentPlayerListResponse
		{
			BidlSessions = null,
			RbdlSessions = null
		};

		await _notificationHandler.EnqueueNotification(new RecentPlayerListNotification
		{
			UserList = null
		});

		return response;
	}
}