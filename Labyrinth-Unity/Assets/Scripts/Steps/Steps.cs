using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Sounds/Steps")]
public class Steps : ScriptableObject
{
    [SerializeField]
    private SoundsList _stepsSounds;
    public SoundsList StepsSounds { get => _stepsSounds;}

    [SerializeField]
    private float _stepLength;
    public float StepLength { get => _stepLength;}

}