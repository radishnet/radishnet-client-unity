using System.Collections.Generic;
using OpenMUX.Types;
using OpenMUX.Types.ServerToClientMessages;
using UnityEngine;

namespace OpenMUX.Networking
{
    public class ReceivedMessageProcessor : MonoBehaviour
    {
        [SerializeField] private StateSender stateSender;

        public void ProcessMessage(byte[] messageInBytes)
        {
            var messageInJson = System.Text.Encoding.UTF8.GetString(messageInBytes);
            var baseMessage = JsonUtility.FromJson<ServerToClientMessage<Object>>(messageInJson);
            switch (baseMessage.type)
            {
                case "WorldStateMessage":
                    var worldStateMessage = JsonUtility.FromJson<WorldStateMessage>(messageInJson);
                    ProcessWorldInfo(worldStateMessage.payload.worldInfo);
                    ProcessPlayerStates(worldStateMessage.payload.playerStates);
                    break;
                case "ClientIdMessage":
                    var clientIdMessage = JsonUtility.FromJson<ClientIdMessage>(messageInJson);
                    ProcessClientId(clientIdMessage.payload);
                    break;
                default:
                    Debug.LogWarning("Unknown message type: " + baseMessage.type);
                    break;
            }
        }

        private void ProcessWorldInfo(WorldInfo worldInfo)
        {
            // Debug.Log(JsonUtility.ToJson(worldInfo));
        }

        private void ProcessPlayerStates(IEnumerable<PlayerState> playerStates)
        {
            foreach (var playerState in playerStates)
            {
                Debug.Log("Received player state: " + JsonUtility.ToJson(playerState));
            }
        }

        private void ProcessClientId(string clientId)
        {
            Debug.Log($"Received client id: {clientId}");
            stateSender.SetClientId(clientId);
        }
    }
}
