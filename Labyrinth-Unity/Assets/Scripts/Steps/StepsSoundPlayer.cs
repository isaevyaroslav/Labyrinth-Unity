using UnityEngine;
using System.Collections;

namespace LabyrinthUnity.StepsNS
{
    public class StepsSoundPlayer
    {
        private AudioSource _audioSource;
        private SoundsList _soundsList;
        public StepsSoundPlayer(AudioSource audioSource, SoundsList soundsList)
        {
            _audioSource = audioSource;
            _soundsList = soundsList;
        }

        public void PlayNextStepSound()
        {

        }
        private void _playStepSound(AudioClip audioClip)
        {
            _audioSource.PlayOneShot(audioClip);
        }
    }
}
