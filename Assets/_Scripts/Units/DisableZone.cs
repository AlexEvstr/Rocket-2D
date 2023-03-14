using UnityEngine;

namespace Evstr.Units
{
    public class DisableZone : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            collision.gameObject.SetActive(false);
        }
    }
}
