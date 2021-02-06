using CSGOMusicPlayer.Models;
using CSGOMusicPlayer.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Media.Control;

namespace CSGOMusicPlayer.Handler
{
    public class MusicHandler : IMusicHandler
    {
        private readonly GlobalSystemMediaTransportControlsSessionManager _musicControl = GlobalSystemMediaTransportControlsSessionManager.RequestAsync().GetAwaiter().GetResult();
        private string lastRoundPhase = "";
        private string lastPlayerId = "";

        private bool IsMusicPlaying()
        {
            return _musicControl.GetCurrentSession().GetPlaybackInfo().PlaybackStatus == GlobalSystemMediaTransportControlsSessionPlaybackStatus.Playing;
        }

        public async Task Handle(CsgoGameStateDto gameState)
        {
            if (lastPlayerId != gameState.player.steamid || lastRoundPhase != gameState.round.phase)
            {
                Console.WriteLine("Status change detected");
                lastRoundPhase = gameState.round.phase;
                lastPlayerId = gameState.player.steamid;
                switch (gameState.round.phase)
                {
                    case "over":
                    case "freeztime":
                    case "warmup":
                        if (!IsMusicPlaying())
                        {
                            await _musicControl.GetCurrentSession().TryPlayAsync();
                        }
                        break;
                    case "live":
                        if (gameState.provider.steamid == gameState.player.steamid)
                        {
                            if (IsMusicPlaying())
                            {
                                await _musicControl.GetCurrentSession().TryPauseAsync();
                            }

                        } else {
                            if (!IsMusicPlaying())
                            {
                                await _musicControl.GetCurrentSession().TryPlayAsync();
                            }
                        }
                        break;
                }
            }

        }
    }
}
