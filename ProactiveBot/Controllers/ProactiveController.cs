using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration;
using Microsoft.Bot.Schema;
using ProactiveBot.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProactiveBot.Controllers
{
    [Route("api/[controller]")]
    public class ProactiveController : Controller
    {
        private readonly BotFrameworkAdapter _adapter;

        public ProactiveController(IAdapterIntegration adapter)
        {
            this._adapter = (BotFrameworkAdapter)adapter;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ObjectResult> Post([FromBody]ProactiveMessage proMsg)
        {
            await _adapter.ContinueConversationAsync(proMsg.BotId, proMsg.Conversation, async (context, token) =>
            {
                await context.SendActivityAsync(proMsg.MessagePayload);
            }, new System.Threading.CancellationToken());

            return Ok("Message Sent");
        }

    }
}
