using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skateboard3Server.Blaze.Handlers.GameManager.Messages;
using Skateboard3Server.Blaze.Managers;
using Skateboard3Server.Blaze.Notifications.GameManager;
using Skateboard3Server.Blaze.Server;

namespace Skateboard3Server.Blaze.Handlers.GameManager;

public class SetGameAttributesHandler : IRequestHandler<SetGameAttributesRequest, SetGameAttributesResponse>
{
    private readonly IGameManager _gameManager;
	private readonly IBlazeNotificationHandler _notificationHandler;

	public SetGameAttributesHandler(IGameManager gameManager, IBlazeNotificationHandler notificationHandler)
    {
        _gameManager = gameManager;
        _notificationHandler = notificationHandler;
	}

    public async Task<SetGameAttributesResponse> Handle(SetGameAttributesRequest request, CancellationToken cancellationToken)
    {
        _gameManager.UpdateAttributes(request.GameId, request.GameAttributes);
        //TODO notify all other users in a game (I Think i did it?)
        var response = new SetGameAttributesResponse();

        var GameAttributeChangeNotification = new GameAttributeChangeNotification
		{
			GameAttributes = request.GameAttributes,
			GameId = request.GameId,
		};

		var game = _gameManager.FindGame(games => games.FirstOrDefault()); //hack

		if (game != null) //tell other players about the change
        {
            foreach (var player in game.Players)
            {
                if (player == null) { continue; }

                await _notificationHandler.EnqueueNotification(player.PersonaId, 
                    GameAttributeChangeNotification);  
            }
        }

        //tell urself about the change
        await _notificationHandler.EnqueueNotification(GameAttributeChangeNotification);

        return response;
    }
}