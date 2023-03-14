using System;
using UnityEngine;
using Zenject;

namespace Evstr.Generals
{
    public class InputSystemAndroid : IInputSystem
    {
        public event Action OnTapped;

        private IUpdateLoop _updater;

        [Inject]
        private void Construct(IUpdateLoop updateLoop)
        {
            _updater = updateLoop;
            OnEnable();
        }

        public void OnEnable()
        {
            _updater.OnUpdate += Update;
        }

        public void OnDisable()
        {
            _updater.OnUpdate -= Update;
        }

        public void Update()
        {
            if(Input.touchCount > 0)
            {
                OnTapped?.Invoke();
            }
        }

    }
}
