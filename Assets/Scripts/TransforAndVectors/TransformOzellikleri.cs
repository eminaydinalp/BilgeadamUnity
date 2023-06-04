using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace TransforAndVectors
{
    public class TransformOzellikleri : MonoBehaviour
    {
        public GameObject targetCube;
        private void Start()
        {
            //SetParent();
            
            //Debug.Log(transform.childCount);
            
            Debug.Log(transform.GetChild(0).name);
            
            transform.GetChild(1).gameObject.SetActive(false);

            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).GetComponent<BoxCollider>().isTrigger = true;
            }
        }

        private void Update()
        {
            //LookAt();
        }

        private void LookAt()
        {
            transform.LookAt(targetCube.transform);
        }

        private void SetParent()
        {
            //transform.SetParent(targetCube.transform);
            targetCube.transform.SetParent(transform);
        }
    }
}
