using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skateboard3Server.Blaze.Handlers.Social.Messages;

namespace Skateboard3Server.Blaze.Handlers.Social;

public class RecentFriendsListHandler : IRequestHandler<RecentPlayerListRequest, RecentPlayerListResponse>
{
	public Task<RecentPlayerListResponse> Handle(RecentPlayerListRequest request, CancellationToken cancellationToken)
	{
		var response = new RecentPlayerListResponse
		{
			BidlSessions = null,
			RbdlSessions = null
		};
		return Task.FromResult(response);
	}
}