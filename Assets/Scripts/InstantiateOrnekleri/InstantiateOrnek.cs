using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace InstantiateOrnekleri
{
    public class InstantiateOrnek : MonoBehaviour
    {
        public GameObject cube;
        private void Start()
        {

            //InstantiateOrnekMethod();
            //RandomOrnek();
            
            //ObjeYakalama();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //RandomOrnek();
            }
        }

        private void RandomOrnek()
        {
            float index = Random.Range(0, 5f);
            
            Debug.Log("İndex : " + index);
        }

        private void InstantiateOrnekMethod()
        {
            // Instantiate(cube, new Vector3(3, 7, 10), Quaternion.identity);
            // Instantiate(cube, transform.position, Quaternion.identity);
            //  Instantiate(cube, 
            //      new Vector3(transform.position.x -2, transform.position.y - 3, transform.position.z),
            //      Quaternion.identity);
            //
            //  for (int i = 0; i < 5; i++)
            //  {
            //      Instantiate(cube, transform.position, Quaternion.identity);
            //  }
            //
            //  for (int i = 0; i < Random.Range(100, 1000); i++)
            //  {
            //      Instantiate(cube, 
            //          new Vector3(Random.Range(-50f, 50f), Random.Range(-50, 50f), Random.Range(-50, 50f)),
            //          Quaternion.identity, transform);
            //  }
             
             for (int i = 0; i < Random.Range(10, 100); i++)
             {
                 Instantiate(cube, 
                     new Vector3(5, Random.Range(-50, 50f), Random.Range(-50, 50f)),
                     Quaternion.identity, transform);
             }
            
             Debug.Log(transform.childCount);
        }

        private void ObjeYakalama()
        {
            GameObject newCube = Instantiate(cube, transform.position, transform.rotation);
            
            //cube.transform.position = Vector3.one * 5;

            newCube.transform.position = Vector3.one * 5;

            newCube.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
