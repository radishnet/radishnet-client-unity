using System;

namespace RadishNet.Types.ServerToClientMessages
{
    [Serializable]
    public class ServerToClientMessage<T>
    {
        public string type;
        public T payload;

        public ServerToClientMessage(string type, T payload)
        {
            this.type = type;
            this.payload = payload;
        }
    }
}
