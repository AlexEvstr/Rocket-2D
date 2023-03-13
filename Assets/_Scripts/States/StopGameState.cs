using UnityEngine;

namespace Evstr.States
{
    public class StopGameState : IState
    {
        public void Enter()
        {
            Time.timeScale = 0;
        }

        public void Exit()
        {

        }
    }
}
