using Evstr.Generals;
using Evstr.States;
using Evstr.Units;
using Evstr.GUI;
using Evstr.GameConfig;
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
        private GameController _gameController;

        public override void InstallBindings()
        {
            GameData gameData = SaveLoadData.Load();
            gameData.TransferDependency(_guiService);
            Container.BindInstance<IGameData>(gameData);

            Container.BindInstance(_guiService);
            Container.BindInstance(_obstacleSpawner);
            Container.BindInstance<IUpdateLoop>(this);
            Container.Bind<IInputSystem>().To<InputSystemAndroid>().AsSingle();

            _gameController = new GameController(gameData);
            Container.BindInstance(_gameController);

            Container.Bind<StateMachine>().AsSingle();
        }
        public void Update()
        {
            OnUpdate?.Invoke();
        }
    }
}
