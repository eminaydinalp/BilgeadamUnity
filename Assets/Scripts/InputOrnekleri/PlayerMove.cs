using System;
using UnityEngine;

namespace InputOrnekleri
{
    public class PlayerMove : MonoBehaviour
    {
        public float horizontal;
        public float vertical;

        public Vector3 direction;

        public float moveSpeed;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            direction = new Vector3(horizontal, 0, vertical);

            //MoveWithTransform();
        }

        private void FixedUpdate()
        {
            MoveWithRigidbody();
        }

        private void MoveWithTransform()
        {
            transform.position += direction * (moveSpeed * Time.deltaTime);
        }

        private void MoveWithRigidbody()
        {
            //_rigidbody.AddForce(direction * moveSpeed);

            direction = direction.normalized;
            
            Debug.Log(direction.magnitude);
            
            _rigidbody.velocity = direction * moveSpeed;
        }
    }
}
