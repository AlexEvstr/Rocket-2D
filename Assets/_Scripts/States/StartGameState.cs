using Evstr.Units;
using Evstr.GUI;
using UnityEngine;

namespace Evstr.States
{
    public class StartGameState : IState
    {
        private ObstacleSpawner _obstacleSpawner;
        private GUIService _guiService;

        public StartGameState(ObstacleSpawner obstacleSpawner, GUIService guiService)
        {
            _obstacleSpawner = obstacleSpawner;
            _guiService = guiService;
        }

        public void Enter()
        {
            Time.timeScale = 1;
            _obstacleSpawner.StartSpawn();
            _guiService.SetVisiblePanelStart(false);
            
        }

        public void Exit() { }
    }
}
