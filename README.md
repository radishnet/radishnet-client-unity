# RadishNet Client

A Unity package that transforms your project into a RadishNet client. It can then send and receive data from and to other clients (via the server).

## Installation

1. Open your Unity project or create a new one
1. Install the Native WebSockets Package as a **git** package
   - In Unity, go to the Package Manager
   - Click on the `+` icon and select `Add package from git URL`
   - Enter `https://github.com/endel/NativeWebSocket.git#upm` and click `add`
1. Install the RadishNet Client Package as a **local** package
   - Download the [RadishNet Client Unity Package as a zip file](https://github.com/radishnet/radishnet-client-unity/archive/refs/heads/main.zip), unzip it and move it to your preferred packages folder
   - In Unity, go to the Package Manager
   - Click on the `+` icon and select `Add package from disk` (adding this one as a local package enables you to customize it)
   - Navigate to where you just placed the package, go inside to the `package.json` file, select it and click `Open`

## Configuring your scene

1. Import the provided samples
   - Go to the Package Manager, select the `RadishNet` package, go the `Samples` tab and hit the import button for each sample
1. Drag the `Networking System` prefab from the `Basic Networking Setup` sample into your scene
   - You can find it in `Assets/Samples/RadishNet/`
1. Configure the Server IP and Port in the `WebSocketClient` script
   - You can find this script in the `Networking System` GameObject
   - The default IP is `localhost`, which if fine if you host the server on the same computer as this project
   - The default Port is `3000`, which should be fine unless you changed it on the server
1. If you don't have a Player object yet, create one consisting of several GameObjects
1. Drag all GameObjects that represent your player to the `Player Objects` array in the `StateSender` script
   - By "GameObjects that represent your player" I mean GameObjects such as the player's Head, Body, ControllerLeft, ControllerRight etc
   - You can find this script in the `Networking System` GameObject

## Starting your scene
1. Make sure the server is started first
1. Start the scene. Your project should now connect to the server and start logging some messages
