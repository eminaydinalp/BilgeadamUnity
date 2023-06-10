using System;
using UnityEngine;

namespace Odev2Folder
{
    public class Odev2Manager : MonoBehaviour
    {
        public GameObject cube;
        public GameObject sphere;
        public GameObject sphere2;
        public GameObject cube2;
        
        private GameObject _cloneCube;
        private GameObject _cloneSphere2;

        [SerializeField] private float _rotationSpeed;
        private void Start()
        {
            #region Soru1
            //_cloneCube = Instantiate(cube);
            
            #endregion

            #region Soru2

            //Instantiate(sphere);

            #endregion
            
            #region Soru3

            //_cloneSphere2 = Instantiate(sphere2);

            #endregion
        }

        private void Update()
        {
            //_cloneCube.transform.Rotate(Vector3.right * (_rotationSpeed * Time.deltaTime));
            
            //cube2.transform.LookAt(_cloneSphere2.transform);
        }
    }
}
