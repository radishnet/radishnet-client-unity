using System;

namespace RadishNet.Types
{
    [Serializable]
    public class WorldState
    {
        public WorldInfo worldInfo;
        public PlayerState[] playerStates;

        public WorldState(WorldInfo worldInfo, PlayerState[] playerStates)
        {
            this.worldInfo = worldInfo;
            this.playerStates = playerStates;
        }
    }
}
