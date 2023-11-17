using UnityEngine;

namespace  Braindrops.Unolith.Inputs
{
    public class UnityInputWrapper : InputProvider
    {
        public float GetAxis(string axisName)
        {
            return Input.GetAxis(axisName);
        }

        public float GetAxisRaw(string axisName)
        {
            return Input.GetAxisRaw(axisName);
        }

        public bool IsButtonDown(string buttonName)
        {
            return Input.GetButtonDown(buttonName);
        }
    }
}