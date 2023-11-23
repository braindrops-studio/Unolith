using System;
using Braindrops.Unolith.Utility;
using UnityEngine;

namespace Braindrops.Unolith.Audio
{
    public class FootSoundPlayer : RandomPitchAudioPlayer
    {
        [SerializeField] private AudioClip defaultAudio;

        private FootSurfaceSound[] soundsDatabase;
        private GroundSurface currentSurface;

        private void Awake()
        {
            soundsDatabase = Resources.LoadAll<FootSurfaceSound>("SoundConfigs");
        }

        private AudioClip GetAudioClipForCurrentSurface()
        {
            foreach (var surfaceSound in soundsDatabase)
            {
                if (surfaceSound.surface == currentSurface)
                    return surfaceSound.clips.GetRandomElement();
            }

            return defaultAudio;
        }

        public void PlayFootSound()
        {
            PlaySound(GetAudioClipForCurrentSurface());
        }
    }
}