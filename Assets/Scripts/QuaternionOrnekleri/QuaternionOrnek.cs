using System;
using UnityEngine;

namespace QuaternionOrnekleri
{
    public class QuaternionOrnek : MonoBehaviour
    {
        [SerializeField] private GameObject cubeObject;
        private void Start()
        {
            //ChangeRotation();
        }

        private void Update()
        {
            //LookRotation();
            
            //Angle();
        }

        private void ChangeRotation()
        {
            //transform.eulerAngles = new Vector3(0, 180, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.identity;
        }

        private void LookRotation()
        {
            transform.rotation = Quaternion.LookRotation(cubeObject.transform.position - transform.position);
            //transform.LookAt(cubeObject.transform); 
        }

        private void Angle()
        {
            float angle = Quaternion.Angle(transform.rotation, cubeObject.transform.rotation);
            
            Debug.Log("Angle : " + angle);
        }
    }
}
