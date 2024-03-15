using System;
using UnityEngine;

namespace OpenMUX.Types
{
    [Serializable]
    public class ObjectState
    {
        public Vector3 position;
        public Quaternion rotation;

        public ObjectState(Vector3 position, Quaternion rotation)
        {
            this.position = position;
            this.rotation = rotation;
        }
    }
}
