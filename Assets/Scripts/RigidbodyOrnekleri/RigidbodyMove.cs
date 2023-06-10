using System;
using UnityEngine;

namespace RigidbodyOrnekleri
{
    public class RigidbodyMove : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        [SerializeField] private float force;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
        }

        private void Update()
        {
            //MoveVelocity();

            if (Input.GetMouseButtonDown(0))
            {
                AddForce();
                //MoveVelocity();
            }
        }

        private void TransformMove()
        {
            //transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }

        private void MoveVelocity()
        {
            _rigidbody.velocity = Vector3.forward * 5;
        }

        private void AddForce()
        {
            _rigidbody.AddForce(Vector3.forward * force, ForceMode.Force);
            _rigidbody.AddForce(Vector3.forward * force, ForceMode.Acceleration);
            _rigidbody.AddForce(Vector3.forward * force, ForceMode.Impulse);
            _rigidbody.AddForce(Vector3.forward * force, ForceMode.VelocityChange);
        }
    }
}
