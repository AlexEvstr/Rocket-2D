using Evstr.GUI;
using Evstr.Units;
using Evstr.Zenject;

namespace Evstr.States
{
    public enum StateGame { START_GAME, STOP_GAME, RESTART_GAME }

    public class StateMachine
    {
        private StartGameState _startGameState;
        private StopGameState _stopGameState;
        private RestartGameState _restartGameState;
        private IState _currenState;

        public StateMachine(ObstacleSpawner obstacleSpawner, GUIService guiService, GameController gameController)
        {
            _startGameState = new StartGameState(obstacleSpawner, guiService);
            _stopGameState = new StopGameState(obstacleSpawner, guiService);
            _restartGameState = new RestartGameState(gameController);
        }

        public void EntryState(StateGame stateGame)
        {
            _currenState?.Exit();
            switch(stateGame)
            {
                case StateGame.START_GAME:
                    _currenState = _startGameState;
                    break;
                case StateGame.STOP_GAME:
                    _currenState = _stopGameState;
                    break;
                case StateGame.RESTART_GAME:
                    _currenState = _restartGameState;
                    break;
            }
            _currenState.Enter();
        }
    }
}
