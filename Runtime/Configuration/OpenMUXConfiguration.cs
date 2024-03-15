using UnityEngine;

namespace OpenMUX.Configuration
{
    [CreateAssetMenu(fileName = "OpenMUXConfiguration", menuName = "OpenMUX/Configuration Asset")]
    public class OpenMuxConfiguration : ScriptableObject
    {
        public string serverIP;
        public int serverPort;
    }
}
