# Open MUX Client
A Unity package that transforms your project into an Open MUX networking client.

## Installation
1. Open your Unity project or create a new one
2. Install the **Native WebSockets** Unity Package
   - Open the Unity Package Manager
   - Click on the `+` icon and select `Add package from git URL`
   - Enter `https://github.com/endel/NativeWebSocket.git#upm` and click `add`
3. Install the **Open MUX Client** Unity Package
   - Open the Unity Package Manager
   - Click on the `+` icon and select `Add package from git URL`
   - Enter `https://github.com/open-mux/open-mux-client-unity.git` and click `add`

## Configuring your scene
1. Drag the `Networking System` from `Packages/Open MUX Client/Runtime/Prefabs` into the root of your scene
2. Drag the GameObject that represents your Player to the `Player` slot in the `Player State Sender` script (which should be one of the scripts in the newly created `Networking System` GameObject)
3. Configure the server address and port settings in the `OpenMUXConfiguration` asset, which should be in your `Assets` folder.
4. Make sure your server is started
5. Start the scene. The application should now automatically connect to the server and start logging some messages.
