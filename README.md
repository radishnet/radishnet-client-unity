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
2. Drag the GameObject that represents your Player (or create a new 3D object in the scene such as a sphere) to the `Player` slot in the `Player State Sender` script (which should be one of the scripts in the newly created `Networking System` GameObject)
3. Create a Configuration Asset by right-clicking on `Assets` and going to `Create` -> `OpenMUX` -> `Configuration Asset`
4. Configure the Server IP and Port in the `OpenMUXConfiguration` asset, which should now be in your `Assets` folder. If you host the server on the same computer as your client, use `localhost` as the ServerIP. If you haven't changed it, the port is probably `3000`
5. Drag this `OpenMUXConfiguration` asset to the `Open Mux Configuration` slot in the `Web Socket Client` script (which should be in the Networking System)
6. Make sure your server is started
7. Start the scene. The application should now automatically connect to the server and start logging some messages
