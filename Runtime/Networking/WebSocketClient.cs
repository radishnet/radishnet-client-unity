using System.Linq;
using NativeWebSocket;
using OpenMUX.Configuration;
using OpenMUX.Types.ClientToServerMessages;
using UnityEngine;

namespace OpenMUX.Networking
{
    public class WebSocketClient : MonoBehaviour
    {
	    [SerializeField] private OpenMuxConfiguration appConfiguration;
	    [SerializeField] private ReceivedMessageProcessor receivedMessageProcessor;
        private WebSocket webSocket;

        private async void Start()
        {
            var serverAddress = $"ws://{appConfiguration.serverIP}:{appConfiguration.serverPort}";
            Debug.Log($"Connecting to server at {serverAddress}.", this);
            webSocket = new WebSocket(serverAddress);
            webSocket.OnOpen += OnWebSocketOpen;
            webSocket.OnMessage += OnWebSocketMessage;
            webSocket.OnError += OnWebSocketError;
            webSocket.OnClose += OnWebSocketClose;
            await webSocket.Connect();
        }

		private void OnWebSocketOpen()
		{
			Debug.Log("Websocket connection open.", this);
		}

		private void OnWebSocketMessage(byte[] message)
		{
			receivedMessageProcessor.ProcessMessage(message);
		}

		private static void OnWebSocketError(string errorMessage)
		{
			Debug.Log("Received error: " + errorMessage);
		}

		private static void OnWebSocketClose(WebSocketCloseCode closeCode)
		{
			Debug.Log("Connection closed with code: " + closeCode);
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
