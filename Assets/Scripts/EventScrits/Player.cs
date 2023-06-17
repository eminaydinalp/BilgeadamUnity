using UnityEngine;

namespace EventScrits
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float jumpPower;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            EventManager.OnGameFinish += Jump;
        }

        private void OnDisable()
        {
            EventManager.OnGameFinish -= Jump;
        }


        private void Jump()
        {
            //transform.position += Vector3.up * jumpPower;
            //_rigidbody.velocity = Vector3.up * jumpPower;
            //_rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            //_rigidbody.AddForce(Vector3.one * jumpPower, ForceMode.Impulse);
            
            //_rigidbody.AddForce(new Vector3(0, 1, 1) * jumpPower, ForceMode.Impulse);
            
            _rigidbody.velocity = Vector3.one * jumpPower;

        }
    }
}

