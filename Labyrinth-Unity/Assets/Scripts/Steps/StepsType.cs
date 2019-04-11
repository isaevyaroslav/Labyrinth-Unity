using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StepsType : MonoBehaviour
{
    [SerializeField]
    private Steps _steps;
    public Steps Steps { get => _steps;}

    private void OnCollisionEnter(Collision collision)
    {
    }
}
