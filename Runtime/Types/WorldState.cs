using System;

namespace OpenMUX.Types
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
