using System;

namespace OpenMUX.Types
{
    [Serializable]
    public class WorldState
    {
        public WorldInfo worldInfo;
        public PlayerState[] playerStates;
        public ObjectState[] objectStates;

        public WorldState(WorldInfo worldInfo, PlayerState[] playerStates, ObjectState[] objectStates)
        {
            this.worldInfo = worldInfo;
            this.playerStates = playerStates;
            this.objectStates = objectStates;
        }
    }
}
