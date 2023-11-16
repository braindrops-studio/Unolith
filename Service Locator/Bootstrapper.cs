using BrainDrops.Unolith.Inputs;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Braindrops.Unolith.ServiceLocator
{
    public class Bootstrapper : MonoBehaviour
    {
        async void Start()
        {
            Application.runInBackground = true;
            await UnityServices.InitializeAsync();
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialize()
        {
            #if UNITY_EDITOR
            var currentlyLoadedEditorScene = SceneManager.GetActiveScene();
            #endif

            if (SceneManager.GetSceneByName("Bootstrapper").isLoaded != true)
                SceneManager.LoadScene("Bootstrapper");
            
            ServiceLocator.Initialize();

            ServiceLocator.Instance.Register(FindObjectOfType<InputService>());
            
            #if UNITY_EDITOR
            if (currentlyLoadedEditorScene.IsValid())
                SceneManager.LoadSceneAsync(currentlyLoadedEditorScene.name, LoadSceneMode.Additive);
            #endif
        }
    }
}