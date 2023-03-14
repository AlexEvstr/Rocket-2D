using Evstr.Generals;
using Evstr.States;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Evstr.Units
{
    public class ObjectPool : MonoBehaviour
    {
        private int _amountToPool = 4;

        [SerializeField] private GameObject _objectToPool;
        private List<GameObject> _pooledObjects;

        private IUpdateLoop _updator;
        private StateMachine _stateMachine;

        public static ObjectPool Instance;

        [Inject]
        public void Construct(IUpdateLoop update, StateMachine stateMachine)
        {
            _updator = update;
            _stateMachine = stateMachine;
        }

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                return;

            _pooledObjects = new List<GameObject>();
        }

        public void InitPool()
        {
            for (int i = 0; i < _amountToPool; i++)
            {
                var obj = Create();
                _pooledObjects.Add(obj);
            }
        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < _pooledObjects.Count; i++)
            {
                if (!_pooledObjects[i].activeInHierarchy)
                {
                    return _pooledObjects[i];
                }
            }
            var obj = Create();
            _pooledObjects.Add(obj);
            return obj;
        }

        private GameObject Create()
        {
            var obj = Object.Instantiate(_objectToPool);
            obj.GetComponent<ObstacleMovement>().Construct(_updator, _stateMachine);
            obj.SetActive(false);
            return obj;
        }
    }
}
