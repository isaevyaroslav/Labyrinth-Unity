using UnityEngine;
using LabyrinthUnity.StepsNS;

[RequireComponent(typeof(AudioSource))]
public class StepsType : MonoBehaviour
{
    [SerializeField]
    private Steps _steps;
    public Steps Steps { get => _steps;}

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StepsDetector stepsDetector = new StepsDetector(collision.gameObject.transform, _steps.StepLength);
            StepsSoundPlayer stepsSoundPlayer = new StepsSoundPlayer(_audioSource, _steps.StepsSounds);
            if (stepsDetector.IsStepMade())
            {
                stepsSoundPlayer.PlayNextStepSound();
            }
        }
    }
}
