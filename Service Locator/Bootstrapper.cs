using BrainDrops.Unolith.Inputs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Braindrops.Unolith.ServiceLocator
{
    public class Bootstrapper : MonoBehaviour
    {
        private void Start()
        {
            Application.runInBackground = true;
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialize()
        {
            #if UNITY_EDITOR
            var currentlyLoadedEditorScene = SceneManager.GetActiveScene();
            #endif

            if (SceneManager.GetSceneByName("Bootstrapper").isLoaded != true)
                SceneManager.LoadScene("Bootstrapper");
            
            GameObject servicesGo = new GameObject("Services");
            DontDestroyOnLoad(servicesGo);
            
            ServiceLocator.Initialize();

            ServiceLocator.Instance.Register(servicesGo.AddComponent<InputService>());
            
            #if UNITY_EDITOR
            if (currentlyLoadedEditorScene.IsValid())
                SceneManager.LoadSceneAsync(currentlyLoadedEditorScene.name, LoadSceneMode.Additive);
            #endif
        }
    }
}