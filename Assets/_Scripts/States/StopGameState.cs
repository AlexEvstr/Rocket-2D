using Evstr.GUI;
using Evstr.Units;
using UnityEngine;

namespace Evstr.States
{
    public class StopGameState : IState
    {
        private ObstacleSpawner _obstacleSpawner;
        private GUIService _guiService;

        public StopGameState(ObstacleSpawner obstacleSpawner, GUIService guiService)
        {
            _obstacleSpawner = obstacleSpawner;
            _guiService = guiService;
        }

        public void Enter()
        {
            Time.timeScale = 0;
            _guiService.SetVisiblePanelGameOver(true);
        }

        public void Exit() { }
    }
}
