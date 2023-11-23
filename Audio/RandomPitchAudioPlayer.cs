using UnityEngine;
using Random = UnityEngine.Random;

namespace Braindrops.Unolith.Audio
{
    public class RandomPitchAudioPlayer : MonoBehaviour
    {
        [SerializeField] [Range(0f, 2f)] private float minPitch;
        [SerializeField] [Range(0, 2f)] private float maxPitch;
        [SerializeField] private AudioSource audioSource;

        public void PlaySound(AudioClip clip)
        {
            audioSource.pitch = Random.Range(minPitch, maxPitch);
            audioSource.PlayOneShot(clip);
        }
    }
}