using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Sounds/SoundsList")]
public class SoundsList : ScriptableObject
{
    [SerializeField]
    private List<AudioClip> _soundsList;
    public List<AudioClip> audioClips { get => _soundsList;}
}
