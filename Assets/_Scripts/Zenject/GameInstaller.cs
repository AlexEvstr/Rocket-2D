using Evstr.Generals;
using Evstr.States;
using Evstr.Units;
using Evstr.GUI;
using System;
using UnityEngine;
using Zenject;

namespace Evstr.Zenject
{
    public class GameInstaller : MonoInstaller, IUpdateLoop
    {
        public event Action OnUpdate;

        [SerializeField] private ObstacleSpawner _obstacleSpawner;
        [SerializeField] private GUIService _guiService;

        public override void InstallBindings()
        {
            Container.BindInstance(_guiService);
            Container.BindInstance(_obstacleSpawner);
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
