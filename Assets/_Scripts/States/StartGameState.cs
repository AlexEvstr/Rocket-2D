using Evstr.Units;
using UnityEngine;

namespace Evstr.States
{
    public class StartGameState : IState
    {
        private ObstacleSpawner _obstacleSpawner;

        public StartGameState(ObstacleSpawner obstacleSpawner)
        {
            _obstacleSpawner = obstacleSpawner;
        }

        public void Enter()
        {
            Time.timeScale = 1;
            _obstacleSpawner.StartSpawn();
            
        }

        public void Exit() { }
    }
}
