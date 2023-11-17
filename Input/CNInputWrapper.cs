using CnControls;

namespace Braindrops.Unolith.Inputs
{
    public class CNInputWrapper : InputProvider
    {
        public float GetAxis(string axisName)
        {
            return CnInputManager.GetAxis(axisName);
        }

        public float GetAxisRaw(string axisName)
        {
            return CnInputManager.GetAxisRaw(axisName);
        }

        public bool IsButtonDown(string buttonName)
        {
            return CnInputManager.GetButtonDown(buttonName);
        }
    }
}