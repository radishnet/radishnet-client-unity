using System;

namespace RadishNet.Types.ClientToServerMessages
{
    [Serializable]
    public class PlayerStateMessage : ClientToServerMessage<PlayerState>
    {
        public PlayerStateMessage(PlayerState playerState) : base("PlayerStateMessage", playerState)
        {
        }
    }
}
