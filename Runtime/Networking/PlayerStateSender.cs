using OpenMUX.Types;
using OpenMUX.Types.ClientToServerMessages;
using UnityEngine;

namespace OpenMUX.Networking
{
    public class PlayerStateSender : MonoBehaviour
    {
        [SerializeField] private WebSocketClient webSocketClient;
        [SerializeField] private GameObject player;
        private string playerId;

        private void Start()
        {
            playerId = "";
        }

        private void Update()
        {
            if (player == null) return;
            if (playerId == "") return;
            SendPlayerStateToServer();
        }

        private void SendPlayerStateToServer()
        {
            var playerState = new PlayerState(playerId, player.transform.position, player.transform.rotation);
            var playerStateMessage = new PlayerStateMessage(playerState);
            webSocketClient.SendMessageToServer(playerStateMessage);
        }

        public void SetPlayerId(string newPlayerId)
        {
            playerId = newPlayerId;
        }
    }
}
