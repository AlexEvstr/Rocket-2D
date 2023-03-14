using Evstr.Zenject;
using UnityEngine;

namespace Evstr.States
{
    public class RestartGameState : IState
    {
        private GameController _gameController;

        public RestartGameState(GameController gameController)
        {
            _gameController = gameController;
        }

        public void Enter()
        {
            _gameController.SaveGame();
            Time.timeScale = 1;
        }

        public void Exit()
        {

        }
    }
}
