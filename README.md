# Open MUX Client
A Unity package that transforms your project into an Open MUX networking client.

## Installation
1. Open your Unity project or create a new one.
2. Install the **Native WebSockets** Unity Package.
   - Open the Unity Package Manager.
   - Click on the `+` icon and select `Add package from git URL`.
   - Enter `https://github.com/endel/NativeWebSocket.git#upm` and click `add`.
3. Install the **Open MUX Client** Unity Package.
   - Open the Unity Package Manager.
   - Click on the `+` icon and select `Add package from git URL`.
   - Enter `https://github.com/open-mux/open-mux-client-unity.git` and click `add`.

## Configuring your scene
1. Import the provided samples.
   - Go to the Package Manager, select the `Open MUX Client` package, go the `Samples` tab, find the sample and hit the import button for each sample.
2. Drag the `Networking System` prefab from the `Basic Networking Setup` sample into your scene.
   - You can find it in `Assets/Samples/Open MUX Client/`.
3. Configure the Server IP and Port in the `WebSocketClient` script.
   - You can find this script in the `Networking System` GameObject.
   - The default IP is `localhost`, which if fine if you host the server on the same computer as this project.
   - The default Port is `3000`, which should be fine unless you changed it on the server.
4. If you don't have a Player object yet, drag the `Player` prefab from the `Basic Player Prefab` sample into your scene.
5. Drag all GameObjects that represent your player to the `Player Objects` array in the `StateSender` script.
   - By "GameObjects that represent your player" I mean GameObjects such as the player's Head, Body, ControllerLeft, ControllerRight etc.
   - You can find this script in the `Networking System` GameObject.
6. Make sure your server is started
7. Start the scene. The application should now connect to the server and start logging some messages
