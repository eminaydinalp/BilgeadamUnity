using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Odev2Folder
{
    public class RandomMove : MonoBehaviour
    {
        private float _gameTime;
        
        [SerializeField] private float repeatTime;

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
        }
    }
}