using System;
using UnityEngine;

namespace Odev2Folder
{
    public class MoveObject : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        private Vector3 _startPosition;

        // ilk pozisyonumuzu yakaladık.
        private void Start()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {

            if (transform.position.z >= 100)
            {
                transform.position = _startPosition;
            }
            transform.Translate(Vector3.forward * (Time.deltaTime * _moveSpeed));

            //transform.position += Vector3.forward * (Time.deltaTime * _moveSpeed);
        }
    }
}