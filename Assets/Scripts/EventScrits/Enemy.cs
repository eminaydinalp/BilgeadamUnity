using System;
using UnityEngine;

namespace EventScrits
{
    public class Enemy : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManager.OnGameFinish += SelfDestroy;
        }

        private void OnDisable()
        {
            EventManager.OnGameFinish -= SelfDestroy;
        }

        private void SelfDestroy()
        {
            Destroy(gameObject);
        }
    }
}
