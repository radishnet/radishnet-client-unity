using OpenMUX.Types;
using OpenMUX.Types.ClientToServerMessages;
using UnityEngine;

namespace OpenMUX.Networking
{
    public class PlayerStateSender : MonoBehaviour
    {
        [SerializeField] private WebSocketClient webSocketClient;
        [SerializeField] private GameObject player;

        private void Update()
        {
            if (player == null) return;
            SendPlayerStateToServer();
        }

        private void SendPlayerStateToServer()
        {
            var playerState = new PlayerState("", player.transform.position, player.transform.rotation);
            var playerStateMessage = new PlayerStateMessage(playerState);
            webSocketClient.SendMessageToServer(playerStateMessage);
        }
    }
}
