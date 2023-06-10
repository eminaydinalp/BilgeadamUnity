using System;
using UnityEngine;

namespace RigidbodyOrnekleri
{
    public class RigidbodyMove : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
        }

        private void Update()
        {
            MoveVelocity();
        }

        private void TransformMove()
        {
            //transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }

        private void MoveVelocity()
        {
            _rigidbody.velocity = Vector3.forward * 5;
        }
    }
}
