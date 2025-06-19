using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Skateboard3Server.Blaze.Handlers.GameManager.Messages;
using Skateboard3Server.Blaze.Managers;
using Skateboard3Server.Blaze.Notifications.GameManager;
using Skateboard3Server.Blaze.Server;

namespace Skateboard3Server.Blaze.Handlers.GameManager;

public class SetGameSettingsHandler : IRequestHandler<SetGameSettingsRequest, SetGameSettingsResponse>
{
    private readonly IGameManager _gameManager;
	private readonly IBlazeNotificationHandler _notificationHandler;

	public SetGameSettingsHandler(IGameManager gameManager, IBlazeNotificationHandler notificationHandler)
    {
        _gameManager = gameManager;
        _notificationHandler = notificationHandler;
    }

    public async Task<SetGameSettingsResponse> Handle(SetGameSettingsRequest request, CancellationToken cancellationToken)
    {
        _gameManager.UpdateSettings(request.GameId, request.GameSettings);

		//TODO notify other players game settings changed (I think i did it?)

		var SetGameSettingsNotification = new GameSettingsChangeNotification
        {
			GameSettings = request.GameSettings,
            GameId = request.GameId,
        };

        var game = _gameManager.FindGame(games => games.FirstOrDefault()); //hack

		if (game != null) //tell other players about the change
		{
			foreach (var player in game.Players)
			{
				if (player == null) { continue; }

				await _notificationHandler.EnqueueNotification(player.PersonaId,
					SetGameSettingsNotification);
			}
		}

		//tell urself about the change
		await _notificationHandler.EnqueueNotification(SetGameSettingsNotification);

		var response = new SetGameSettingsResponse();
        return response;
    }
}