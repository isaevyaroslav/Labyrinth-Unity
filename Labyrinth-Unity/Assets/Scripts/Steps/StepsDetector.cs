using UnityEngine;

namespace LabyrinthUnity.StepsNS
{
    public class StepsDetector
    {
        private Transform _playerPosition;
        private float _stepLength;
        private float _currentStepLength;

        public StepsDetector(Transform playerPosition, float stepLength)
        {
            _playerPosition = playerPosition;
            _stepLength = stepLength;
        }

        public bool IsStepMade()
        {
            if(_currentStepLength == _stepLength)
            {
                _currentStepLength = 0;
                return true;
            }
            return false;
        }
    }
}
