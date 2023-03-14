using Evstr.GUI;
using Evstr.States;
using UnityEngine;
using Zenject;

namespace Evstr
{
    public class UIRestartButton : UIBaseButton
    {
        private StateMachine _stateMachine;
        [Inject]
        public void Construct(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        public override void OnClick()
        {
            _stateMachine.EntryState(StateGame.RESTART_GAME);
        }
    }
}
