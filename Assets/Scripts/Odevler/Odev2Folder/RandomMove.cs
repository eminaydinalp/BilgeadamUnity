using UnityEngine;
using Random = UnityEngine.Random;

namespace Odevler.Odev2Folder
{
    public class RandomMove : MonoBehaviour
    {
        private float _gameTime;
        
        [SerializeField] private float repeatTime;
        public GameObject cube;

        private void Start()
        {
            cube = GameObject.FindGameObjectWithTag("Cube");
        }

        private void Update()
        {
            _gameTime += Time.deltaTime;
            
            if (_gameTime > repeatTime)
            {
                Move();
                _gameTime = 0;
            }
        }

        private void Move()
        {
            transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            
            // Obje ile aramızda belli bir mesafeyi koruyoruz
            
            if (Vector3.Distance(transform.position, cube.transform.position) < 4)
            {
                Move();
            }
        }
    }
}