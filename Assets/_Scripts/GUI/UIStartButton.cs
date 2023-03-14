using Evstr.States;
using Zenject;

namespace Evstr.GUI
{
    public class UIStartButton : UIBaseButton
    {
        private StateMachine _stateMachine;

        [Inject]
        public void Construct(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        public override void OnClick()
        {
            _stateMachine.EntryState(StateGame.START_GAME);
        }
    }
}
