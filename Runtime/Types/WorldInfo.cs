using System;

namespace RadishNet.Types
{
    [Serializable]
    public class WorldInfo
    {
        public string weather;

        public WorldInfo(string weather)
        {
            this.weather = weather;
        }
    }
}
