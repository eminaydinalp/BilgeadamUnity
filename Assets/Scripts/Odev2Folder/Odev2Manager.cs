using System;
using UnityEngine;

namespace Odev2Folder
{
    public class Odev2Manager : MonoBehaviour
    {
        public GameObject cube;
        public GameObject sphere;
        private GameObject _cloneCube;

        [SerializeField] private float _rotationSpeed;
        private void Start()
        {
            #region Soru1
            //_cloneCube = Instantiate(cube);
            
            #endregion

            #region Soru2

            Instantiate(sphere);

            #endregion
        }

        private void Update()
        {
            //_cloneCube.transform.Rotate(Vector3.right * (_rotationSpeed * Time.deltaTime));
        }
    }
}
