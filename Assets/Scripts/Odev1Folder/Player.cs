using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Odev1Folder
{
    public class Player : MonoBehaviour
    {
        public string name;
        public int health;
        public int power;
        public bool isDead;
        
        

        public void DoAttack()
        {
            
        }

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (health <= 0)
            {
                Debug.Log("Öldünüz");
                isDead = true;
            }
        }
    }
}

