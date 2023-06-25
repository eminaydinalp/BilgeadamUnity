using System;
using ObjectPoolOrnekleri;
using UnityEngine;
using UnityEngine.UIElements;

namespace InstantiateOrnekleri
{
    public class Bullet : MonoBehaviour, IPoolable
    {
        public float speed;
        public string PoolType => _poolType;
        [SerializeField] private string _poolType;
        private void Start()
        {
            //DestroyBullet();
        }

        private void Update()
        {
            if (transform.position.z > 100)
            {
                //Destroy(gameObject);
                ObjectPoolerWithList.Instance.ReturnObject(gameObject);
            }
            
            Move();
        }
        
        public void Move()
        {
            transform.position += Vector3.forward * (Time.deltaTime * speed);
            //transform.position += transform.up * (Time.deltaTime * speed);
        }

        public void DestroyBullet()
        {
            Destroy(gameObject, 2);
        }

       
    }
}
