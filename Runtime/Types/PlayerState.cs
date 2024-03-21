using System;
using UnityEngine;

namespace OpenMUX.Types
{
    [Serializable]
    public class PlayerState
    {
        public string clientId;
        public Vector3 headPosition;
        public Quaternion headRotation;

        public PlayerState(string clientId, Vector3 headPosition, Quaternion headRotation)
        {
            this.clientId = clientId;
            this.headPosition = headPosition;
            this.headRotation = headRotation;
        }
    }
}
