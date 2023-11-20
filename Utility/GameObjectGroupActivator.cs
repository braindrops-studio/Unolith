using UnityEngine;

namespace Braindrops.Unolith.Utility
{
    public class GameObjectGroupActivator : ObjectActivator
    {
        private GameObject[] gameObjects;

        public GameObjectGroupActivator(GameObject[] gameObjects)
        {
            this.gameObjects = gameObjects;
        }

        public void Activate()
        {
            foreach (var gameObject in gameObjects)
                gameObject.SetActive(true);
        }

        public void Deactivate()
        {
            foreach (var gameObject in gameObjects)
                gameObject.SetActive(false);
        }
    }
}