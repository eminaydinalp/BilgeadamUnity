using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Odev2Folder
{
    public class Odev2Manager : MonoBehaviour
    {
        public GameObject cube;
        public GameObject sphere;
        public GameObject sphere2;
        public GameObject cube2;
        public CapsuleCollider capsule;
        
        private GameObject _cloneCube;
        private GameObject _cloneSphere2;

        [SerializeField] private float _rotationSpeed;


        public GameObject[] objects;
        private void Start()
        {
            #region Soru1
            //_cloneCube = Instantiate(cube);
            
            #endregion

            #region Soru2

            //Instantiate(sphere);

            #endregion
            
            #region Soru3

            _cloneSphere2 = Instantiate(sphere2);

            #endregion

            #region Soru4
            
            // for (int i = 0; i < 10; i++)
            // {
            //     CapsuleCollider newCapsule = Instantiate(capsule, 
            //         new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f)),
            //         Quaternion.identity, transform);
            //
            //     newCapsule.isTrigger = true;
            //     newCapsule.center += new Vector3(2, 4, 7);
            //     newCapsule.radius = 3;
            // }

            #endregion

            #region Soru5

            //Instantiate(objects[Random.Range(0, objects.Length)]);
            
            //InvokeRepeating(nameof(RandomObjectSpawn), 0, 2);
            #endregion
            
        }

        private void Update()
        {
            //_cloneCube.transform.Rotate(Vector3.right * (_rotationSpeed * Time.deltaTime));
            
            //cube2.transform.LookAt(_cloneSphere2.transform);

            _cloneSphere2.transform.position = 
                Vector3.Lerp(_cloneSphere2.transform.position, cube2.transform.position, Time.deltaTime * 10);
        }

        private void RandomObjectSpawn()
        {
            Instantiate(objects[Random.Range(0, objects.Length)], 
                new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f)),
                Quaternion.identity);
        }
    }
}
