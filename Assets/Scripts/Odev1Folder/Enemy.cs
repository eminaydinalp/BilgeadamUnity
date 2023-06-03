using System;
using UnityEngine;

namespace Odev1Folder
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player player;

        private void Start()
        {
            player.TakeDamage(20);
        }
    }
}
