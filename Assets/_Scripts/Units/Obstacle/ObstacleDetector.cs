using Evstr.States;
using UnityEngine;

namespace Evstr.Units
{
    public class ObstacleDetector : IDetector
    {
        private StateMachine _stateMachine;

        public void Construct(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        public void OnCollision()
        {
            _stateMachine.EntryState(StateGame.STOP_GAME);
        }
    }
}
