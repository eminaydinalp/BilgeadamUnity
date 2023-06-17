using System;
using System.Collections;
using UnityEngine;

namespace InvokeOrnekleri
{
    public class CapsuleController : MonoBehaviour
    {
        [SerializeField] private GameObject _mermi;
        
        private Coroutine creationBullet;

        int _bulletIndex;
        

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_bulletIndex % 2 == 0)
                {
                    creationBullet = StartCoroutine(CreateMermi(50));
                }
                else
                {
                    StopCoroutine(creationBullet);
                }

                _bulletIndex++;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                //StopCoroutine(CreateMermi(50)); => yanlış kod
                
                //StopCoroutine(creationBullet);
            } 
        }

        private IEnumerator CreateMermi(int count)
        {
            for (int i = 0; i < count; i++)
            {
                //if(i > 5) yield break;
                
                Instantiate(_mermi);
                yield return new WaitForSeconds(0.1f);
            }
            
            Debug.Log("finish");
        }
    }
}
