using System.Linq;
using OpenMUX.Types;
using OpenMUX.Types.ClientToServerMessages;
using UnityEngine;

namespace OpenMUX.Networking
{
    public class StateSender : MonoBehaviour
    {
        [SerializeField] private WebSocketClient webSocketClient;
        [SerializeField] private GameObject[] playerObjects;
        private string clientId = "";

        private void Update()
        {
            if (playerObjects.Length == 0) return;
            if (clientId == "") return;
            SendPlayerStateToServer();
        }

        private void SendPlayerStateToServer()
        {
            var playerState = new PlayerState(clientId, playerObjects.Select(playerObject => new NetworkObject(playerObject.name, playerObject.transform.position, playerObject.transform.rotation)).ToArray());
            var playerStateMessage = new PlayerStateMessage(playerState);
            webSocketClient.SendMessageToServer(playerStateMessage);
        }

        public void SetClientId(string newClientId)
        {
            clientId = newClientId;
        }
    }
}
