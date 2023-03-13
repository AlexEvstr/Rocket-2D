using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.States
{
    public enum StateGame { START_GAME, STOP_GAME, RESTART_GAME }

    public class StateMachine
    {
        private StartGameState _startGameState;
        private StopGameState _stopGameState;
        private RestartGameState _restartGameState;
        private IState _currenState;

        public StateMachine()
        {

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
