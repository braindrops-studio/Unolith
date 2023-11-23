using UnityEngine;

namespace Braindrops.Unolith.Audio
{
    [CreateAssetMenu(fileName = "FootSurfaceSound", menuName = "Audio/FoorSurfaceSound", order = 0)]
    public class FootSurfaceSound : ScriptableObject
    {
        public GroundSurface surface;
        public AudioClip[] clips;
    }
}