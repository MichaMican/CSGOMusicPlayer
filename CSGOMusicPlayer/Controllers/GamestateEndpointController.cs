using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGOMusicPlayer.Interfaces;
using CSGOMusicPlayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSGOMusicPlayer.Controllers
{
    [ApiController]
    [Route("")]
    public class GamestateEndpointController : ControllerBase
    {
        private IMusicHandler _musicHandler;

        public GamestateEndpointController(IMusicHandler musicHandler)
        {
            _musicHandler = musicHandler;
        }

        [HttpPost]
        public async Task<ActionResult> HandlePost([FromBody] CsgoGameStateDto csgoGameState)
        {
            if (csgoGameState == null || csgoGameState.player == null || csgoGameState.map == null)
            {
                return Ok();
            }

            await _musicHandler.Handle(csgoGameState);

            return Ok();
        }
    }
}
