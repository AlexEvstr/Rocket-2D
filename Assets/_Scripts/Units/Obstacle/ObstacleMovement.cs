using Evstr.Generals;
using Evstr.States;
using UnityEngine;

namespace Evstr.Units
{
    public class ObstacleMovement : MonoBehaviour
    {
        [SerializeField] private ObstacleDetector _obstacleDetector;

        private float _obstacleSpeed = 5.0f;

        private IUpdateLoop _updator;

        public void Construct(IUpdateLoop update, StateMachine stateMachine)
        {
            _updator = update;

            _obstacleDetector.Construct(stateMachine);
            _updator.OnUpdate += Movement;
        }

        private void OnDestroy()
        {
            _updator.OnUpdate -= Movement;
        }

        private void Movement()
        {
            transform.Translate(-_obstacleSpeed * Time.deltaTime, 0, 0);
        }
    }
}
