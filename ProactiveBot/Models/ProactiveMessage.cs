using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;

namespace ProactiveBot.Models
{
    public class ProactiveMessage
    {
        public string BotId { get; set; }
        public ConversationReference Conversation { get; set; }
        public string MessagePayload { get; set; }
    }
}
