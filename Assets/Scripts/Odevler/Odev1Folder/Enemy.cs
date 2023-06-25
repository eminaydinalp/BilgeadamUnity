using UnityEngine;

namespace Odevler.Odev1Folder
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private global::Odevler.Odev1Folder.Player player;

        private void Start()
        {
            player.TakeDamage(20);
        }
    }
}
