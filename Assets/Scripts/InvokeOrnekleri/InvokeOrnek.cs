using System;
using UnityEngine;

namespace InvokeOrnekleri
{
    public class InvokeOrnek : MonoBehaviour
    {
        private void Start()
        {
            //Method1();
            
            //Invoke("Method1", 2);
            
            Invoke(nameof(Method1), 2);
            
            Method2();
            
            InvokeRepeating(nameof(Method2), 0, 1);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                CancelInvoke(nameof(Method2));
            }
            
            if (Input.GetKeyDown(KeyCode.B))
            {
                CancelInvoke(nameof(Method1));
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                InvokeRepeating(nameof(Method2), 0, .1f);
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                enabled = false;
            }
        }

        private void Method1()
        {
            Debug.Log("Method 1 çalıştı");
        }
        
        private void Method2()
        {
            Debug.Log("Method 2 çalıştı");
        }
    }
}
