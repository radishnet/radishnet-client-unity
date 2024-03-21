using OpenMUX.Types.ServerToClientMessages;
using UnityEngine;

namespace OpenMUX.Networking
{
    public class ReceivedMessageProcessor : MonoBehaviour
    {
        [SerializeField] private PlayerStateSender playerStateSender;

        public void ProcessMessage(byte[] messageInBytes)
        {
            var messageInJson = System.Text.Encoding.UTF8.GetString(messageInBytes);
            var baseMessage = JsonUtility.FromJson<ServerToClientMessage<Object>>(messageInJson);

            switch (baseMessage.type)
            {
                case "WorldStateMessage":
                    var worldStateMessage = JsonUtility.FromJson<WorldStateMessage>(messageInJson);
                    var worldInfo = worldStateMessage.payload.worldInfo;
                    var playerStates = worldStateMessage.payload.playerStates;
                    foreach (var playerState in playerStates)
                    {
                        Debug.Log("Received player state: " + JsonUtility.ToJson(playerState));
                    }
                    var objectStates = worldStateMessage.payload.objectStates;
                    foreach (var objectState in objectStates)
                    {
                        Debug.Log("Received object state: " + JsonUtility.ToJson(objectState));
                    }
                    break;
                default:
                    Debug.LogWarning("Unknown message type: " + baseMessage.type);
                    break;
            }
        }
    }
}
