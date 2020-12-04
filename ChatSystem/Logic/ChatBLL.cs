using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocketManager;

namespace ChatSystem.Logic
{
    public class ChatBLL : WebSocketHandler
    {
        public ChatBLL(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {
        }
    }
}
