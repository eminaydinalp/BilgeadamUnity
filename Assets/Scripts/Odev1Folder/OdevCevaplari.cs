using System;
using UnityEngine;

namespace Odev1Folder
{
    public class OdevCevaplari : MonoBehaviour
    {
        private BoxCollider _boxCollider;
        private Rigidbody _rigidbody;

        private Rigidbody[] _rigidbodies;

        private SphereCollider _sphereCollider;
        private void Awake()
        {
            _boxCollider = GetComponent<BoxCollider>();
            _rigidbody = GetComponent<Rigidbody>();
            
            _rigidbodies = GetComponentsInChildren<Rigidbody>();

            _sphereCollider = GameObject.FindGameObjectWithTag("Sphere").GetComponent<SphereCollider>();
        }

        private void Start()
        {
            //ChangeBoxCollider();
            //ChangeRigidbody();

            //RigidbodyChangeUseGravity();

           //ChangeSphere();
        }

        private void ChangeBoxCollider()
        {
            _boxCollider.isTrigger = true;
            Debug.Log(_boxCollider.isTrigger);
        }

        private void ChangeRigidbody()
        {
            _rigidbody.mass = 10;
            _rigidbody.drag = 2;
            
            Debug.Log("Mass : " + _rigidbody.mass);
            Debug.Log("Drag : " + _rigidbody.drag);
        }

        private void RigidbodyChangeUseGravity()
        {
            foreach (var rigidbody1 in _rigidbodies)
            {
                rigidbody1.useGravity = false;
                rigidbody1.isKinematic = true;
            }
        }

        private void ChangeSphere()
        {
            _sphereCollider.radius = 3;
            _sphereCollider.isTrigger = true;
        }
    }
}