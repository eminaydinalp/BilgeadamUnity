using System.Collections;
using UnityEngine;

namespace InvokeOrnekleri
{
    public class CoroutineOrnekleri : MonoBehaviour
    {
        [SerializeField] private bool _isDead;
        
        private void Start()
        {
            //StartCoroutine(Method1());
            
            //Method2();

            StartCoroutine(Method3());
        }

        private IEnumerator Method1()
        {
            yield return new WaitForSeconds(2);
            
            Debug.Log("Method 1 Çalıştı");

            yield return new WaitForSeconds(1f);
            
            Debug.Log("Method 1 bitti");
        }

        private void Method2()
        {
            Debug.Log("Method 2 Çalıştı");
        }

        private IEnumerator Method3()
        {
            yield return new WaitUntil(() => _isDead);
            //yield return new WaitUntil(() => !_isDead);
            //yield return new WaitWhile(() => _isDead);
            
            Debug.Log("Öldük");
        }
    }
}
