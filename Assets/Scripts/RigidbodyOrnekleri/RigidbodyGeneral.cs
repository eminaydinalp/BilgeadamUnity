using System;
using UnityEngine;

namespace RigidbodyOrnekleri
{
    public class RigidbodyGeneral : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            _rigidbody.mass = 100;
            _rigidbody.drag = 2;
            _rigidbody.angularDrag = 0.7f;
            _rigidbody.useGravity = true;
            _rigidbody.isKinematic = false;
            //_rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            _rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationY;
        }
    }
}
