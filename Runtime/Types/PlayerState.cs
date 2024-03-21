using System;

namespace OpenMUX.Types
{
    [Serializable]
    public class PlayerState
    {
        public string clientId;
        public NetworkObject[] playerObjects;

        public PlayerState(string clientId, NetworkObject[] playerObjects)
        {
            this.clientId = clientId;
            this.playerObjects = playerObjects;
        }
    }
}
