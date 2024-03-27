using System;

namespace RadishNet.Types.ServerToClientMessages
{
    [Serializable]
    public class WorldStateMessage : ServerToClientMessage<WorldState>
    {
        public WorldStateMessage(string type, WorldState payload) : base(type, payload)
        {
        }
    }
}
