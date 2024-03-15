using System;

namespace OpenMUX.Types.ClientToServerMessages
{
    [Serializable]
    public class ClientToServerMessage<T>
    {
        public string type;
        public T payload;

        public ClientToServerMessage(string type, T payload)
        {
            this.type = type;
            this.payload = payload;
        }
    }
}
