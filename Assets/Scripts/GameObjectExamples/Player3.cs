using System;
using UnityEngine;

namespace GameObjectExamples
{
    public class Player3 : MonoBehaviour
    {
        public int health;
        public string name;

        private void Start()
        {
            Debug.Log(gameObject.name);

        }

        public void TakeDamage()
        {
            health -= 10;
        }
    }
}
