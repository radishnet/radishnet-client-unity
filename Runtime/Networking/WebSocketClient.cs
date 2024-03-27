using System.Linq;
using NativeWebSocket;
using RadishNet.Types.ClientToServerMessages;
using UnityEngine;

namespace RadishNet.Networking
{
    public class WebSocketClient : MonoBehaviour
    {
        private WebSocket webSocket;
        [SerializeField] private string serverIP = "localhost";
        [SerializeField] private int serverPort = 3000;
        [SerializeField] private ReceivedMessageProcessor receivedMessageProcessor;

        private void Start()
        {
            var serverAddress = $"ws://{serverIP}:{serverPort}/?clientType=vr";
            Debug.Log($"Connecting to server at {serverAddress}.", this);
            webSocket = new WebSocket(serverAddress);
            webSocket.OnOpen += OnWebSocketOpen;
            webSocket.OnMessage += OnWebSocketMessage;
            webSocket.OnError += OnWebSocketError;
            webSocket.OnClose += OnWebSocketClose;
            webSocket.Connect();
        }

		private void OnWebSocketOpen()
		{
			Debug.Log("Websocket connection open.", this);
		}

		private void OnWebSocketMessage(byte[] message)
		{
			receivedMessageProcessor.ProcessMessage(message);
		}

		private void OnWebSocketError(string errorMessage)
		{
			Debug.LogError("Received error: " + errorMessage, this);
		}

		private void OnWebSocketClose(WebSocketCloseCode closeCode)
		{
			Debug.Log("Connection closed with code: " + closeCode, this);
		}

		public async void SendMessageToServer<T>(ClientToServerMessage<T> message)
		{
			var messageTypesToIgnore = new [] { "PlayerStateMessage" };
			if (!messageTypesToIgnore.Contains(message.type)) Debug.Log("Sending message to server: " + JsonUtility.ToJson(message));

			if (webSocket.State != WebSocketState.Open)
			{
				Debug.LogWarning("Message could not be sent to server; websocket not open");
				return;
			}
			await webSocket.SendText(JsonUtility.ToJson(message));
		}

		private void Update()
		{
#if !UNITY_WEBGL || UNITY_EDITOR
			webSocket.DispatchMessageQueue();
#endif
		}

		private async void OnApplicationQuit()
		{
			Debug.Log("Application quitting; closing websocket");
			await webSocket.Close();
		}
    }
}
