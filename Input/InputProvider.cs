using UnityEngine;

namespace BrainDrops.Unolith.Inputs
{
    public interface InputProvider
    {
        public float GetAxis(string axisName);
        public float GetAxisRaw(string axisName);

        public bool IsButtonDown(string buttonName);
    }
}