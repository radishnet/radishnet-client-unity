using System;

namespace OpenMUX.Types.ServerToClientMessages
{
    [Serializable]
    public class PlayerIdMessage : ServerToClientMessage<string>
    {
        public PlayerIdMessage(string type, string payload) : base(type, payload)
        {
        }
    }
}
