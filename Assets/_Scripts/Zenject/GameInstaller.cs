using Evstr.Generals;
using Evstr.States;
using System;
using Zenject;

namespace Evstr.Zenject
{
    public class GameInstaller : MonoInstaller, IUpdateLoop
    {
        public event Action OnUpdate;

        public override void InstallBindings()
        {
            Container.BindInstance<IUpdateLoop>(this);
            Container.Bind<IInputSystem>().To<InputSystemAndroid>().AsSingle();

            Container.Bind<StateMachine>().AsSingle();
        }
        public void Update()
        {
            OnUpdate?.Invoke();
        }
    }
}
