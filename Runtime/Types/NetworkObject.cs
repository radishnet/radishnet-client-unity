using System;
using UnityEngine;

namespace RadishNet.Types
{
    [Serializable]
    public class NetworkObject
    {
        public string id;
        public Vector3 position;
        public Quaternion rotation;

        public NetworkObject(string id, Vector3 position, Quaternion rotation)
        {
            this.id = id;
            this.position = position;
            this.rotation = rotation;
        }
    }
}
