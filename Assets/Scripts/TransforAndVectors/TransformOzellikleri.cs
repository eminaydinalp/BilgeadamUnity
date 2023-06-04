using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace TransforAndVectors
{
    public class TransformOzellikleri : MonoBehaviour
    {
        public GameObject targetCube;
        public BoxCollider[] boxColliders;
        public CubeControl[] cubeControllers;
        private void Start()
        {
            //SetParent();
            
            //GetChildOzellikleri();
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

        private void GetChildOzellikleri()
        {
            Debug.Log(transform.childCount);
            
             Debug.Log(transform.GetChild(0).name);
            
             transform.GetChild(1).gameObject.SetActive(false);
            
             for (int i = 0; i < transform.childCount; i++)
             {
                 BoxCollider boxCollider = transform.GetChild(i).GetComponent<BoxCollider>();
                 boxCollider.isTrigger = true;
                 boxCollider.size *= 2;
                 boxCollider.center += Vector3.one;
                 Debug.Log(boxCollider.center);
                 Debug.Log(boxCollider.size);
             }

             foreach (var boxCollider in boxColliders)
             {
                 boxCollider.isTrigger = true;
             }
            
            foreach (var cubeController in cubeControllers)
            {
                cubeController.cubeCount = 5;
            }

        }
    }
}
