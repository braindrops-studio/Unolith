using Braindrops.Unolith.ServiceLocator;
using UnityEngine;

namespace BrainDrops.Unolith.Inputs
{
    public class InputService : MonoBehaviour, GameService
    {
        private InputProvider inputProvider;

        public string DraggedItemName { get; private set; } = "";
        public float HorizontalInput { get; private set; }
        public float VerticalInput { get; private set; }
        public bool IsPressingJump { get; private set; }

        private void Awake()
        {
            inputProvider = new UnityInputWrapper();
        }

        public void DragItem(string itemName)
        {
            DraggedItemName = itemName;
        }

        private void Update()
        {
            HorizontalInput = inputProvider.GetAxis("Horizontal");
            VerticalInput = inputProvider.GetAxis("Vertical");
            IsPressingJump = inputProvider.IsButtonDown("Jump");
        }
    }
}