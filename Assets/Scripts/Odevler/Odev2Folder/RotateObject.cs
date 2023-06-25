using UnityEngine;

namespace Odevler.Odev2Folder
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;
        private void Update()
        {
            transform.Rotate(Vector3.right * (_rotationSpeed * Time.deltaTime));
        }
    }
}
