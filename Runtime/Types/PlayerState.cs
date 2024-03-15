using System;
using UnityEngine;

namespace OpenMUX.Types
{
    [Serializable]
    public class PlayerState
    {
        public string id;
        public Vector3 headPosition;
        public Quaternion headRotation;

        public PlayerState(string id, Vector3 headPosition, Quaternion headRotation)
        {
            this.id = id;
            this.headPosition = headPosition;
            this.headRotation = headRotation;
        }
    }
}
