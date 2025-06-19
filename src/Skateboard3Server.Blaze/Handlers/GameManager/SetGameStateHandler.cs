using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skateboard3Server.Blaze.Handlers.GameManager.Messages;
using Skateboard3Server.Blaze.Managers;
using Skateboard3Server.Blaze.Notifications.GameManager;
using Skateboard3Server.Blaze.Server;

namespace Skateboard3Server.Blaze.Handlers.GameManager;

public class SetGameStateHandler : IRequestHandler<SetGameStateRequest, SetGameStateResponse>
{
    private readonly IGameManager _gameManager;
	private readonly IBlazeNotificationHandler _notificationHandler;

    public SetGameStateHandler(IGameManager gameManager, IBlazeNotificationHandler notificationHandler)
    {
        _gameManager = gameManager;
		_notificationHandler = notificationHandler;
    }

    public async Task<SetGameStateResponse> Handle(SetGameStateRequest request, CancellationToken cancellationToken)
    {
        _gameManager.UpdateState(request.GameId, request.GameState);
		//TODO notify other players game settings changed (I think I did it?)

		var GameStateChangeNotification = new GameStateChangeNotification
		{
			GameId = request.GameId,
			GameState = request.GameState,
		};

		var game = _gameManager.FindGame(games => games.FirstOrDefault()); //hack

		if (game != null) //tell other players about the change
		{
			foreach (var player in game.Players)
			{
				if (player == null) { continue; }

				await _notificationHandler.EnqueueNotification(player.PersonaId,
					GameStateChangeNotification);
			}
		}

		//tell urself about the change
		await _notificationHandler.EnqueueNotification(GameStateChangeNotification);

		var response = new SetGameStateResponse();
        return response;
    }
}