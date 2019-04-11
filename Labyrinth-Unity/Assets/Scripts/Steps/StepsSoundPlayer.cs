using UnityEngine;
using System.Collections;

namespace LabyrinthUnity.StepsNS
{
    public class StepsSoundPlayer
    {
        private AudioSource _audioSource;
        public StepsSoundPlayer(AudioSource audioSource)
        {
            _audioSource = audioSource;
        }

        public void PlayStepsSound(SoundsList soundsList)
        {

        }
        private void _playStepSound(AudioSource audioSource, AudioClip audioClip)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
