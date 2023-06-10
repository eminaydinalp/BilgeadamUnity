using System;
using UnityEngine;

namespace RigidbodyOrnekleri
{
    public class TriggerOrnek : MonoBehaviour
    {
        // Mutlaka iki objeden birinde rigidbody olmak zorunda
        // Mutlaka iki objeden birinde isTrigger true olmak zorunda
        private void OnTriggerEnter(Collider other)
        {
            // Çarpışma ilk olduğunda bir kere tetiklenir.
            
            Debug.Log("Çapışma Başladı");
        }

        private void OnTriggerStay(Collider other)
        {
            // Çarpışma devam ettiği sürece çalışır.
            
            Debug.Log("Temas devam ediyor");
        }

        private void OnTriggerExit(Collider other)
        {
            // Çarpışma sonlandığı anda bir kere tetiklenir.
            
            Debug.Log("Çarpışma sonlandı");
        }
    }
}
