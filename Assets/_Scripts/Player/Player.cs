using Evstr.Generals;
using Evstr.Units;
using UnityEngine;
using Zenject;

namespace Evstr.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        public Rigidbody2D GetRigidbody2D => _rigidbody2D;

        private IPlayerBehaviour _playerBehaviour;
        private IInputSystem _inputSystem;

        private float _forceUp = 5.0f;
        public float ForceUp => _forceUp;

        [Inject]
        private void Construct(IInputSystem inputSystem)
        {
            _inputSystem = inputSystem;

            _rigidbody2D = GetComponent<Rigidbody2D>();
            _playerBehaviour = new PlayerBehaviour(this);
        }

        private void OnEnable()
        {
            _inputSystem.OnTapped += _playerBehaviour.MoveUp;
        }

        private void OnDisable()
        {
            _inputSystem.OnTapped -= _playerBehaviour.MoveUp;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            IDetector detector = collision.gameObject.GetComponent<IDetector>();
            if (detector != null)
                detector.OnCollision();
        }
    }
}
