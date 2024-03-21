using OpenMUX.Types;
using OpenMUX.Types.ClientToServerMessages;
using UnityEngine;

namespace OpenMUX.Networking
{
    public class PlayerStateSender : MonoBehaviour
    {
        [SerializeField] private WebSocketClient webSocketClient;
        [SerializeField] private GameObject playerGameObject;
        private string clientId;

        private void Start()
        {
            clientId = "";
        }

        private void Update()
        {
            if (playerGameObject == null) return;
            if (clientId == "") return;
            SendPlayerStateToServer();
        }

        private void SendPlayerStateToServer()
        {
            var playerState = new PlayerState(clientId, playerGameObject.transform.position, playerGameObject.transform.rotation);
            var playerStateMessage = new PlayerStateMessage(playerState);
            webSocketClient.SendMessageToServer(playerStateMessage);
        }

        public void SetClientId(string newClientId)
        {
            clientId = newClientId;
        }
    }
}
