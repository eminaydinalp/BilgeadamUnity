using System;
using UnityEngine;

namespace RigidbodyOrnekleri
{
    public class CollisionOrnek : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            // Çarpışma ilk olduğunda bir kere tetiklenir.
            
            Debug.Log("Çapışma Başladı");
        }
        
        private void OnCollisionStay(Collision collisionInfo)
        {
            // Çarpışma devam ettiği sürece çalışır.
            
            Debug.Log("Temas devam ediyor");
        }
        private void OnCollisionExit(Collision other)
        {
            // Çarpışma sonlandığı anda bir kere tetiklenir.
            
            Debug.Log("Çarpışma sonlandı");
        }

    }
}
