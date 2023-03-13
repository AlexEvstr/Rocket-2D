using UnityEngine;

namespace Evstr.Player
{
    public class PlayerBehaviour : IPlayerBehaviour
    {
        private Player _player;

        public PlayerBehaviour(Player player)
        {
            _player = player;
        }

        public void MoveUp()
        {
            _player.GetRigidbody2D.velocity = Vector2.up * _player.ForceUp;
        }
    }
}
