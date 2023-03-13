using UnityEngine;

namespace Evstr.States
{
    public class StartGameState : IState
    {
        public void Enter()
        {
            Time.timeScale = 1;
        }

        public void Exit()
        {

        }
    }
}
