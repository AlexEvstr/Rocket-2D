using Evstr.Zenject;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Evstr.States
{
    public class RestartGameState : IState
    {
        public void Enter()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }

        public void Exit()
        {

        }
    }
}
