using System;

namespace OpenMUX.Types.ClientToServerMessages
{
    [Serializable]
    public class PlayerStateMessage : ClientToServerMessage<PlayerState>
    {
        public PlayerStateMessage(PlayerState playerState) : base("PlayerStateMessage", playerState)
        {
        }
    }
}
