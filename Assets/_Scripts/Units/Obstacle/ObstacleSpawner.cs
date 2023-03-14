using System.Collections;
using UnityEngine;

namespace Evstr.Units
{
    public class ObstacleSpawner : MonoBehaviour
    {
        private float _coordinateX = 12.0f;
        private float _coordinateY;
        private float _borderY;
        private Vector2 _spawnPosition;

        public void StartSpawn()
        {
            _spawnPosition = new Vector2();
            ObjectPool.Instance.InitPool();
            StartCoroutine(Spawner());
        }

        private IEnumerator Spawner()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                _coordinateY = Random.Range(-_borderY, _borderY);
                GameObject obstacle = ObjectPool.Instance.GetPooledObject();
                if (obstacle != null)
                {
                    _spawnPosition.x = _coordinateX;
                    _spawnPosition.y = _coordinateY;
                    obstacle.transform.position = _spawnPosition;
                    obstacle.SetActive(true);
                }
            }
        }
    }
}
